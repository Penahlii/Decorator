public interface DataSource
{
    void WriteData(string data);
    void ReadData();
}

public class FileDataSource : DataSource
{
    private string _filename;

    public FileDataSource(string filename)
    {
        this._filename = filename;
    }

    public void ReadData()
    {
        // read data from file
    }

    public void WriteData(string data)
    {
        // write data to file
    }
}

public class DataSourceDecorator : DataSource
{
    private DataSource _wrappee;


    public DataSourceDecorator() { }

    public DataSourceDecorator(DataSource wrappee)
    {
        _wrappee = wrappee;
    }

    public void ReadData()
    {
        // read data from wrappee
    }

    public void WriteData(string data)
    {
        // write data to wrapee
    }
}

public class EncryptionDecorator : DataSourceDecorator
{
    public void ReadData()
    {
        // appropriate algorithm for Reading Data
    }

    public void WriteData(string data)
    {
        // appropriate algorithm for Writing Data
    }
}

public class CompressionDecorator : DataSourceDecorator
{
    public void ReadData()
    {
        // appropriate algorithm for Reading Data
    }

    public void WriteData(string data)
    {
        // appropriate algorithm for Writing Data
    }
}