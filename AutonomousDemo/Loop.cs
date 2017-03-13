using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutonomousDemo
{
    public class Loop
    {

        public void GameLoop(bool answer)
        {
            int lastTime = DateTime.Now.Millisecond;
            
            while (true)
            {
                int start = DateTime.Now.Millisecond;
                ProcessInput();
                // Update();
                //Render();
                Thread.Sleep(900);
            }

        }

        private void Render()
        {
            throw new NotImplementedException();
        }

        private void Update()
        {
            throw new NotImplementedException();
        }

        private void ProcessInput()
        {
            
        }
    }
}
