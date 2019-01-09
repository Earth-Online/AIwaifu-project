using (DnsServer server = new DnsServer(IPAddress.Any, 10, 10, ProcessQuery))
{
	server.Start();
	Console.WriteLine("Press any key to stop server");
	Console.ReadLine();
}

static DnsMessageBase ProcessQuery(DnsMessageBase message, IPAddress clientAddress, System.Net.Sockets.ProtocolType protocol)
{
	message.IsQuery = false;
	DnsMessage query = message as DnsMessage;

	// 官方的样例文档中没有体现DNS请求发起者的IP，我在这里增加了。
	Console.WriteLine("Client Address:{0}", clientAddress.ToString()); 
	Console.WriteLine("query.Questions.Count:{0}", query.Questions.Count);
	Console.WriteLine("query.Questions.ToString():{0}", query.Questions.ToString());
	Console.WriteLine("query.Questions[0].ToString():{0}", query.Questions[0].ToString());
	Console.WriteLine("query.Questions[0].GetType():{0}", query.Questions[0].GetType().ToString()); 
	Console.WriteLine("query.Questions[0].Name:{0}", query.Questions[0].Name.ToString());
	Console.WriteLine("query.Questions[0].RecordType:{0}", query.Questions[0].RecordType.ToString());
	Console.WriteLine("query.Questions[0].RecordClass {0}", query.Questions[0].RecordClass.ToString());

	if (query.Questions[0].Name.Contains("subB.mooo.com"))
	{

		Console.WriteLine("Contains subB.mooo.com");
		query.AnswerRecords.Add(new ARecord("xxx.subB.mooo.com", 3600, IPAddress.Parse("9.9.9.9")));
		message.ReturnCode = ReturnCode.NoError;
		return message;

	}
	else
	{
		Console.WriteLine("!!! not Contains mooo");
		message.ReturnCode = ReturnCode.ServerFailure;
		Console.WriteLine(message.ReturnCode.ToString());

		return message;
	}
}



string domain = query.Questions[0].Name.ToString();
if (domain == "test.com.")
{
	response.AnswerRecords.Add(new ARecord(query.Questions[0].Name, 36000, IPAddress.Parse("1.1.1.1")));
	response.ReturnCode = ReturnCode.NoError;
}
else
{
	var DnsClientR = new DnsClient(IPAddress.Parse("127.0.0.1"), 3000).Resolve(query.Questions[0].Name);
	if (DnsClientR != null)
	{
		foreach (var i in DnsClientR.AnswerRecords)
		{
			var j = i as ARecord;
			if (j != null)
				query.AnswerRecords.Add(j);
		}
		response.ReturnCode = ReturnCode.NoError;
	}
}
