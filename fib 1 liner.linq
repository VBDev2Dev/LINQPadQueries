<Query Kind="VBStatements">
  <Reference>&lt;RuntimeDirectory&gt;\System.Numerics.dll</Reference>
  <Namespace>System.Numerics</Namespace>
</Query>

Dim fib = Enumerable.Range(1, 600).
	Select(Function(e) Enumerable.Range(1, e).
		Skip(2).
		Aggregate(New KeyValuePair(Of BigInteger, BigInteger)(1l, 1l),
			Function(seq, index) New KeyValuePair(Of BigInteger, BigInteger)(seq.Value, seq.Key + seq.Value)).Value)

'still a one liner just more readable
fib.Dump