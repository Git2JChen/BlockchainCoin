using System;
using NBitcoin;

namespace ProgrammingBlockchain.Chapters
{
    public class Chapter1
    {
        public Chapter1()
        {
        }

        public void Lesson1()
        {
            Key key = new Key();    //generate a new private key
            PubKey pubKey = key.PubKey; //gets the matching public key
            Console.WriteLine("Public key: {0}", pubKey);
            KeyId hash = pubKey.Hash;   //gets a hash of the public key
            Console.WriteLine("Hashed Ppblic key: {0}", hash);
            BitcoinAddress address = pubKey.GetAddress(Network.Main);   //retrieves the bitcoin address
            Console.WriteLine("Address: {0}", address);
            Script scritptPubkeyFromAddress = address.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from address: {0}", scritptPubkeyFromAddress);
            Script scriptPubkeyFromHas = hash.ScriptPubKey;
            Console.WriteLine("ScriptPubKey from hash: {0}", scriptPubkeyFromHas);
        }
    }
}

