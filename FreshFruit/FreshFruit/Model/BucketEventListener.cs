using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFruit.model
{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }

}