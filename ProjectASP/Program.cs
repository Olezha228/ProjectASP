// ReSharper disable CommentTypo
var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";

    // ���� ��������� ���� �� ������ "/postuser", �������� ������ �����
    // ReSharper disable once StringLiteralTypo
    if (context.Request.Path == "/postuser")
    {
        var form = context.Request.Form;
        string name = form["name"];
        string age = form["age"];
        await context.Response.WriteAsync($"<div><p>Name: {name}</p><p>Age: {age}</p></div>");
    }
    else
    {
        await context.Response.SendFileAsync("html/index.html");
    }
});

app.Run();
