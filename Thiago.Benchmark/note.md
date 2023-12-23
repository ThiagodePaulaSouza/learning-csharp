using StreamReader reader = new StreamReader(path);
string json = await reader.ReadToEndAsync();
return JsonConvert.DeserializeObject<T>(json);