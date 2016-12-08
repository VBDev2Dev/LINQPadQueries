<Query Kind="VBStatements" />

Dim fib=Enumerable.Range(1,60).Select(Function(e)  Enumerable.Range(1, e).Skip(2).Aggregate(New KeyValuePair (Of  Long, Long)  (1l, 1l), Function(seq, index)  New KeyValuePair (Of Long, Long)(seq.Value, seq.Key + seq.Value)).Value) 
fib.Dump
