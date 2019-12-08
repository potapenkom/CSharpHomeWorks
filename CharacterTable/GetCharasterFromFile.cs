using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CharacterTable
{
    public static class GetCharasterFromFile
    {
        public static List<Character> CharasterSerialize()
        {
            var characters = CharactersService.GetCharacters();
            characters.Clear();
            using (FileStream stream = new FileStream(@"C:\Projects\Characters.txt", FileMode.Open))
            {
                var deserializer = new BinaryFormatter();
                characters = deserializer.Deserialize(stream) as List<Character>;
                return characters;
            }

        }
    }
}