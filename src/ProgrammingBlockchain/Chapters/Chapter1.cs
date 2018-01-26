using System;
using NBitcoin;

namespace ProgrammingBlockchain.Chapters
{
    public class Chapter1
    {
        private string _scriptPubkeyValue;

        public Chapter1()
        {
            _scriptPubkeyValue = "OP_DUP OP_HASH160 1b2da6ee52ac5cd5e96d2964f12a0241851f8d2a OP_EQUALVERIFY OP_CHECKSIG";
        }

        public string ScriptPubkeyValue => _scriptPubkeyValue;

        public void Lesson1()
        {
            Console.WriteLine("====================== Lesson 1 ======================");
            Console.WriteLine("\n");

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

            //set ScriptPubkeyValue property
            _scriptPubkeyValue = scriptPubkeyFromHas.ToString();
        }

        public void Lesson2(string scriptPubKeyValue)
        {
            //var scriptPubKeyValue = "OP_DUP OP_HASH160 1b2da6ee52ac5cd5e96d2964f12a0241851f8d2a OP_EQUALVERIFY OP_CHECKSIG";
            Script scriptPubKey = new Script(scriptPubKeyValue);
            BitcoinAddress address = scriptPubKey.GetDestinationAddress(Network.Main);

            Console.WriteLine("\n");
            Console.WriteLine("====================== Lesson 2 ======================");
            Console.WriteLine("\n");
            Console.WriteLine("Bitcoin Address: {0}", address);
        }
    }
}

