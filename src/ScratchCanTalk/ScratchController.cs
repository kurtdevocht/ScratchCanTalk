using System.Net;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Text;
using System.Web.Http;

namespace ScratchCanTalk
{
    public class ScratchController : ApiController
    {
        [Route("poll")]
        [HttpGet]
        public HttpResponseMessage Poll()
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            var content = new StringBuilder();

            // For this  extension no content needs to be returned...
            //
            // content.Append("sensorX 123\n");

            resp.Content = new StringContent(content.ToString(), Encoding.UTF8, "text/plain");
            return resp;
        }

        [Route("speak/{thingToSay}/{gender}")]
        [HttpGet]
        public HttpResponseMessage Speak(string thingToSay, string gender)
        {
            var synth = this.BuildSynth(gender);
            synth.SpeakAsync(thingToSay);
            return this.OkResponse;
        }

        private SpeechSynthesizer BuildSynth(string gender)
        {
            var synth = new SpeechSynthesizer();
            if (!string.IsNullOrEmpty(gender) && gender.ToUpper() == "BOY")
            {
                synth.SelectVoiceByHints(VoiceGender.Male);
            }
            else
            {
                synth.SelectVoiceByHints(VoiceGender.Female);
            }

            return synth;
        }

        private HttpResponseMessage OkResponse
        {
            get
            {
                var resp = new HttpResponseMessage(HttpStatusCode.OK);
                resp.Content = new StringContent(string.Empty, Encoding.UTF8, "text/plain");
                return resp;
            }
        }
    }
}
