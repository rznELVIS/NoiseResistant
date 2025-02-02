using SystemModel.Interfaces;

namespace SystemModel;

public class DataTransmissionSystemModel : IDataTransmissionSystemModel
{
    private readonly IGenarator _generator;

    public DataTransmissionSystemModel(
        IGenerator generator
    ) 
    {
        _generator = generator;
    }
    

    public void Model()
    {
        throw new NotImplementedException();
    }
}
