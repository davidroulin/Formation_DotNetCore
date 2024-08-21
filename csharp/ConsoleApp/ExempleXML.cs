using System;
using System.Xml;

internal class ExempleXML
{

	public static void Run()
	{
		XmlReader reader = XmlReader.Create("C:\\Users\\davidroulin\\Desktop\\ORN\\ORN_Training\\ConsoleApp01\\fichiers\\EssaiXML.xml");
		
		//reader.MoveToFirstAttribute();
		
		while (reader.Read())
		{
			XmlNodeType nodeType = reader.NodeType;
			switch (nodeType)
			{
				case XmlNodeType.Element:
					Console.WriteLine(reader.Name);
					while (reader.MoveToNextAttribute())
					{
						//case XmlNodeType.Attribute:
						Console.WriteLine(reader.Name);
						Console.WriteLine(reader.Value);
					}
					break;
				//case XmlNodeType.Attribute:
				//	Console.WriteLine(reader.Value);
				//	break;
				case XmlNodeType.EndElement:
					Console.WriteLine(reader.Name);
					break;
				case XmlNodeType.Text:
					Console.WriteLine(reader.Value);
					break;
					//case XmlNodeType.EndEntity:
					//	break;
					//case XmlNodeType.None:
					//	break;
					//case XmlNodeType.CDATA:
					//	break;
					//case XmlNodeType.EntityReference:
					//	break;
					//case XmlNodeType.Entity:
					//	break;
					//case XmlNodeType.ProcessingInstruction:
					//	break;
					//case XmlNodeType.Comment:
					//	break;
					//case XmlNodeType.Document:
					//	break;
					//case XmlNodeType.DocumentType:
					//	break;
					//case XmlNodeType.DocumentFragment:
					//	break;
					//case XmlNodeType.Notation:
					//	break;
					//case XmlNodeType.Whitespace:
					//	break;
					//case XmlNodeType.SignificantWhitespace:
					//	break;
					//case XmlNodeType.XmlDeclaration:
					//	break;
					//default:
					//	break;
			}

		}

	}

}
