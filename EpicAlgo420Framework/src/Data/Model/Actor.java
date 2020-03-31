package Data.Model;

public class Actor{

    private String fornavn, etternavn;
    private int alder;
    
        public Actor(String fornavn, String etternavn, int alder) {
            this.fornavn = fornavn;
            this.etternavn = etternavn;
            this.alder = alder;
        }
    
        public String getFornavn() {
            return fornavn;
        }
    
        public void setFornavn(String fornavn) {
            this.fornavn = fornavn;
        }
    
        public String getEtternavn() {
            return etternavn;
        }
    
        public void setEtternavn(String etternavn) {
            this.etternavn = etternavn;
        }
    
        public int getAlder() {
            return alder;
        }
    
        public void setAlder(int alder) {
            this.alder = alder;
        }
    
        @Override
        public String toString() {
    
           return getFornavn() + " " + getEtternavn() + " - " + " " + "Alder" + ": " + getAlder();
    
        }


    
    
    
    }
    