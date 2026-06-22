select * from(
select top 3 'Buy' as order_type ,product_name,count(*) as total_orders, FORMAT(avg(price),'N2') as average_order_price  from buy_orders
where dt between '2024-02-01' and '2024-02-30'
group by product_name
order by 4 desc ) b
 
union all

select * from (
select  top 3 'Sell' as order_type ,product_name,count(*) as total_orders, FORMAT(avg(price),'N2') as average_order_price from sell_orders
where dt between '2024-02-01' and '2024-02-30'
group by product_name
order by 4 desc) s





select * from (
    select top 3
        'Buy' as order_type,
        product_name,
        count(product_name) as total_orders,
        FORMAT(avg(price),'N2') as average_order_price
    from buy_orders
    where dt between '2024-02-01' and '2024-02-30'
    group by product_name
    order by avg(price) desc
) b

union all

select * from (
    select top 3
        'Sell' as order_type,
        product_name,
        count(*) as total_orders,
        FORMAT(avg(price),'N2') as average_order_price
    from sell_orders
    where dt between '2024-02-01' and '2024-02-30'
    group by product_name
    order by avg(price) desc
) s;











using System.Reflection.Metadata.Ecma335;

var serverNumber = 3;
var x = 5;

List<List<int>> log_data = new List<List<int>>
{
    new List<int> { 1, 3 },
    new List<int> { 2, 6 },
    new List<int> { 1, 5 }
};

var query = new int[] { 10,11 };


Dictionary<int, List<int>> serverLogs = new Dictionary<int, List<int>>();
foreach (var item in log_data)
{
    serverLogs.TryAdd(item[0], new List<int>());
    for (int i = 1; i < item.Count; i++)
    {
        serverLogs[item[0]].Add(item[i]);
    }
}



List<int> serverNotRecived = new List<int>();

for (int q = 0; q < query.Length; ++q)
{
    List<int> serverNotRecivedForQuery = new List<int>();
    var minTime = query[q] - x;
    var maxTime = query[q];

    for (int s = 1; s <= serverNumber; s++)
    {
        if (serverLogs.TryGetValue(s, out var logs))
        {
            if (logs.Any(l => l >= minTime && l <= maxTime))
                continue;
            else
                serverNotRecivedForQuery.Add(s);
        }
        else
        {
            serverNotRecivedForQuery.Add(s);
        }
    }
    serverNotRecived.Add(serverNotRecivedForQuery.Count);

}
foreach (var item in serverNotRecived)
{
    Console.WriteLine(item);
}

static int[] getStaleServerCount(int n, List<List<int>> log_data, int[] query, int x)
{
    Dictionary<int, List<int>> serverLogs = new Dictionary<int, List<int>>();
    foreach (var item in log_data)
    {
        serverLogs.TryAdd(item[0], new List<int>());
        for (int i = 1; i < item.Count; i++)
        {
            serverLogs[item[0]].Add(item[i]);
        }
    }
    List<int> serverNotRecived = new List<int>();
    for (int q = 0; q < query.Length; ++q)
    {
        List<int> serverNotRecivedForQuery = new List<int>();
        var minTime = query[q] - x;
        var maxTime = query[q];
        for (int s = 1; s <= n; s++)
        {
            if (serverLogs.TryGetValue(s, out var logs))
            {
                if (logs.Any(l => l >= minTime && l <= maxTime))
                    continue;
                else
                    serverNotRecivedForQuery.Add(s);
            }
            else
            {
                serverNotRecivedForQuery.Add(s);
            }
        }
        serverNotRecived.Add(serverNotRecivedForQuery.Count);
    }
    return serverNotRecived.ToArray();
}
//Function Description
//Complete the function getStaleServerCount in the editor with the following parameters:
//    int n: the number of servers
//    int log_data[m] [2]:  the logs of the servers
//    int query[q]:  the queries
//    int x: a parameter for queries












// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] worlds = new[] { "Hello", "World", "test","Apple","green", "Apple1", "green2" };

var l = Console.ReadLine();

var match = worlds.Select(w => w.ToLower()).Where(w => w.StartsWith(l.ToLower()));
var autoCompleted = match.Order().Take(3);
foreach (var w in autoCompleted)
{
    Console.WriteLine(w);
}
















