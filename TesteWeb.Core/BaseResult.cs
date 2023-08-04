using System;
namespace TesteWeb.Core;

public class BaseResult<T>
{
    public BaseResult()
    {
    }

    public int Code { get; set; }
    public bool Sucess { get; set; }
    public string Message { get; set; }
    public T? Data { get; set; }

    public static BaseResult<T> Ok(T data)
    {
        return new BaseResult<T>()
        {
            Code = 200,
            Sucess = true,
            Message = "Operação realizada com sucesso.",
            Data = data
        };
    }
}

