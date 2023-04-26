using DatabaseProject.Models;
using Interface;
using Services;

namespace Library
{
    public class Storage
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; } 
        
        private TypeService typeService = new TypeService();

        private ProductService productService = new ProductService();

        private StockService stockService = new StockService();
        public Storage(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
           
            MostrarOpciones();
        }
  
        public async Task<bool> Registrar()
        {
            bool esRegistrado = false;
            
            Product product = new Product();
            try
            {
                product = GenerateProduct();
                stockService.Add(product.Code);
                esRegistrado = productService.Add(product);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return esRegistrado;
        }

        public bool Modificar()
        {
            bool isModified = false;
            Console.WriteLine("Ingrese el Id del producto que desea modificar: ");
            string idProduct = Console.ReadLine();
            Product product;
            try
            {
                int idProdInt = Int32.Parse(idProduct);
                product = productService.GetById(idProdInt);

                if (product == null) {
                    Console.WriteLine("Lo sentimos no encontramos un producto con el codigo " + idProduct);
                    return false; 
                }
                int oldCode = product.Code;
                Product productGenerated = GenerateProduct();
                product.Name = StringVerify(productGenerated.Name) ? productGenerated.Name : product.Name;
                product.Origin = StringVerify(productGenerated.Origin) ? productGenerated.Origin : product.Origin;
                product.Price = productGenerated.Price != -1 ? productGenerated.Price : product.Price;
                product.BrandModel = StringVerify(productGenerated.BrandModel) ? productGenerated.BrandModel : product.BrandModel;
                product.IdType = productGenerated.IdType != 0 ? productGenerated.IdType : product.IdType; 
                product.Code = productGenerated.Code != 0 ? productGenerated.Code : product.Code;
                productService.Update(product, oldCode);
                isModified = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           

           return isModified;
        }

        private bool StringVerify(string testString)
        {
            return !String.IsNullOrEmpty(testString) && !String.IsNullOrWhiteSpace(testString); 
        }
        private Product GenerateProduct()
        {
            Console.Write("Ingrese el nombre del producto: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el codigo del producto numeral: ");
            string code = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la descripcion del producto: ");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el precio del producto: ");
            string price = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la procedencia del producto: ");
            string origin = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la marca o el modelo: ");
            string brandModel = Console.ReadLine();
            Console.WriteLine("Por favor ingrese el número del tipo de producto");
            List<DatabaseProject.Models.Type> types = typeService.GetTypes().ToList();
            for (int i = 0; i < types.Count; i++)
            {
                Console.WriteLine(types[i].Id + ".: " + types[i].Name);
            }
            string type = Console.ReadLine();
            Product product = new Product();
            try
            {
                product.Origin = String.IsNullOrEmpty(origin) ? "" : origin;
                product.BrandModel = brandModel;
                decimal priceDecimal;
                product.Price = decimal.TryParse(price, out priceDecimal) ?  priceDecimal : -1;
                product.Name = name;
                product.Description = description;
                int codeInt, typeInt;
                product.Code = Int32.TryParse(code, out codeInt) ? codeInt : 0;
                product.IdType = Int32.TryParse(type, out typeInt) ? typeInt : 0;
                if (typeInt < 1 || typeInt > types.Count) throw new Exception("type is incorrect");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return product; 
        }

        public bool Eliminar()
        {
            bool isDeleted = false;
            Console.WriteLine("Ingrese el id del producto que desea eliminar");
            string idString = Console.ReadLine();
            try
            {
                int idProdInt = Int32.Parse(idString);
                Product product = productService.GetById(idProdInt);

                if (product == null)
                {
                    Console.WriteLine("Lo sentimos no encontramos un producto con el codigo " + idString);
                    return false;
                }
                 isDeleted = productService.Delete(idProdInt);
                if (isDeleted) Console.WriteLine("Eliminado exitosamente");
                if (!isDeleted) Console.WriteLine("No se logro eliminar");


            }
            catch (Exception ex)
            {
                isDeleted = false;
                Console.WriteLine(ex.Message);
            }
            return isDeleted;
        }

        public void ShowStorageDetail()
        {
            List<Product> products = productService.GetAll();
            products.ForEach((product) =>
            {                
                Console.WriteLine(product);
                Console.WriteLine(stockService.Get(product.Code));
                Console.WriteLine(typeService.GetType(product.IdType));
            });
        }

        public bool MostrarOpciones()
        {
            bool closeOption = false;
            Console.WriteLine("Bienvenido al Almacen: "+Nombre);
            Console.WriteLine("Por favor ingrese el numero de alguna de las opciones: ");
            Console.WriteLine("1.- Registrar");
            Console.WriteLine("2.- Modificar");
            Console.WriteLine("3.- Eliminar");
            Console.WriteLine("4.- Detalle Almacen");
            Console.WriteLine("5.- Limpiar Pantalla");
            Console.WriteLine("6.- Salir");
            string type = Console.ReadLine();
            switch (type)
            {
                case "1":
                    this.Registrar();
                    break;
                case "2":
                    this.Modificar();
                    break;
                case "3":
                    this.Eliminar();
                    break;
                case "4":
                    this.ShowStorageDetail();
                    break;
                case "5":
                    Console.Clear();
                    break;
                case "6":
                    closeOption = true;
                    break;
                default:
                    break;
            }
            return closeOption;
        }


    }
}
