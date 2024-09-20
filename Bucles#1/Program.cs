 //Primer punto
 Dictionary<string,int> productos= new Dictionary<string, int>();
 productos.Add("camisetas", 175000);
 productos.Add("zapatos", 350000);
 productos.Add("tenis", 280000);
 productos.Add("jeans", 200000);

 //Precios de los elementos de la lista
 int precio_camisetas= productos["camisetas"];
 int precio_zapatos= productos["zapatos"];
 int precio_tenis= productos["tenis"];
 int precio_jeans= productos["jeans"];

//clientes
for (int i = 1; i < 4; i++)
{
    Console.WriteLine($"Cliente numero {i}");
    for (int j = 0; j < 4; j++)
    {
        Console.Write("Ingrese el producto que esta buscando (camisetas,zapatos,tenis,jeans): ");
        string elemento= Console.ReadLine();

        switch (elemento)
        {
            case "camisetas":
                Console.WriteLine($"Las camisetas tienen un precio de {precio_camisetas}");
            break;

            case "zapatos":
                Console.WriteLine($"Los zapatos tienen un precio de {precio_zapatos}");
            break;

            case "tenis":
                Console.WriteLine($"Los tenis tienen un precio de {precio_tenis}");
            break;

            case "jeans":
                Console.WriteLine($"Los jeans tienen un precio de {precio_jeans}");
            break;

        }

    }
}
