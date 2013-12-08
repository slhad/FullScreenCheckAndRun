using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FSCR.Libs
{
    class BFGMiner
    {
        String server;
        int port;

        RPC_Client rc;

        public BFGMiner(string server, int port)
        {
            this.server = server;
            this.port = port;

            if (rc == null)
            {
                rc = new RPC_Client(server, port);
            }
        }

        public int getGPUs()
        {
            int nGPU = 0;
            String rGPU = rc.request("gpucount");
            if (rGPU != "")
            {
                String[] t = rGPU.Split('|');
                if (t.Length > 1)
                {
                    String gpuN = t[1];
                    nGPU = Int32.Parse(gpuN.Split('=')[1]);
                }
            }
            return nGPU;
        }

    }
}
