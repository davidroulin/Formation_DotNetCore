using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class ExempleDAT
{

	public class ObjectToSerialize {
		public string message;
	}

	//public static void Write(string filepath)
	//{
	//	ObjectToSerialize objectToSerialize = new ObjectToSerialize
	//	{
	//		message = "yo"
	//	};
	//	Stream stream = File.Open(filepath, FileMode.Truncate);
	//	BinaryFormatter bFormatter = new BinaryFormatter();
	//	bFormatter.Serialize(stream, objectToSerialize);
	//	stream.Close();
	//}

	//public static void Read(string filepath)
	//{
	//	ObjectToSerialize deserializedObject;
	//	Stream stream = File.Open(filepath, FileMode.Open);
	//	BinaryFormatter bFormatter = new BinaryFormatter();
	//	objectToSerialize = (ObjectToSerialize)bFormatter.Deserialize(stream);
	//	stream.Close();
	//	Console.WriteLine(deserializedObject.message);
	//}

}
