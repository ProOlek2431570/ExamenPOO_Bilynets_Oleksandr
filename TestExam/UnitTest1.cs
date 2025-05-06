using ExamenFinalPratique;
namespace TestExam
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            InstrumentACorde instrument1 = new InstrumentACorde(8);
            InstrumentACorde instrument2 = new InstrumentACorde(3);

            InstrumentACorde meilleurInstrument;

            if( instrument1 > instrument2 )
                meilleurInstrument = instrument1;            
            else
                meilleurInstrument = instrument2;

            Assert.Equal(instrument1, meilleurInstrument);
        }
    }
}