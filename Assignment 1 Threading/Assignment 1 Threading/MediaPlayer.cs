//Julian Blair 141119
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Assignment_1_Threading
{
    class MediaPlayer
    {
        private SoundPlayer splayer = new SoundPlayer();
        
        /// <summary>
        /// Gets the sound player.
        /// </summary>
        /// <value>
        /// The sound player.
        /// </value>
        public SoundPlayer SoundPlayer{ get{return splayer;}}

        /// <summary>
        /// Plays the specified file name.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public void Play(string fileName)
        {
            splayer.SoundLocation = fileName;
            splayer.Play();
        }

        /// <summary>
        /// Stops the specified s.
        /// </summary>
        /// <param name="s">The s.</param>
        public void Stop(SoundPlayer s)
        {
            s.Stop();
        }
    }
}
