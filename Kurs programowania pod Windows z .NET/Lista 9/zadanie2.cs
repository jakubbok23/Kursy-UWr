﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="mojedane", IsNullable=false)]
public partial class ListaStudentow {
    
    private ListaStudentowStudent[] studentField;
    
    private string nazwaField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Student")]
    public ListaStudentowStudent[] Student {
        get {
            return this.studentField;
        }
        set {
            this.studentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nazwa {
        get {
            return this.nazwaField;
        }
        set {
            this.nazwaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
public partial class ListaStudentowStudent {
    
    private string imieField;
    
    private string nazwiskoField;
    
    private ListaStudentowStudentAdresStaly[] adresStalyField;
    
    private ListaStudentowStudentAdresTymczasowy[] adresTymczasowyField;
    
    private ListaStudentowStudentListaZajecPrzedmiot[][] listaZajecField;
    
    /// <remarks/>
    public string Imie {
        get {
            return this.imieField;
        }
        set {
            this.imieField = value;
        }
    }
    
    /// <remarks/>
    public string Nazwisko {
        get {
            return this.nazwiskoField;
        }
        set {
            this.nazwiskoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdresStaly")]
    public ListaStudentowStudentAdresStaly[] AdresStaly {
        get {
            return this.adresStalyField;
        }
        set {
            this.adresStalyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AdresTymczasowy")]
    public ListaStudentowStudentAdresTymczasowy[] AdresTymczasowy {
        get {
            return this.adresTymczasowyField;
        }
        set {
            this.adresTymczasowyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Przedmiot", typeof(ListaStudentowStudentListaZajecPrzedmiot), IsNullable=false)]
    public ListaStudentowStudentListaZajecPrzedmiot[][] ListaZajec {
        get {
            return this.listaZajecField;
        }
        set {
            this.listaZajecField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
public partial class ListaStudentowStudentAdresStaly {
    
    private string miastoField;
    
    private string ulicaField;
    
    /// <remarks/>
    public string Miasto {
        get {
            return this.miastoField;
        }
        set {
            this.miastoField = value;
        }
    }
    
    /// <remarks/>
    public string Ulica {
        get {
            return this.ulicaField;
        }
        set {
            this.ulicaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
public partial class ListaStudentowStudentAdresTymczasowy {
    
    private string miastoField;
    
    private string ulicaField;
    
    /// <remarks/>
    public string Miasto {
        get {
            return this.miastoField;
        }
        set {
            this.miastoField = value;
        }
    }
    
    /// <remarks/>
    public string Ulica {
        get {
            return this.ulicaField;
        }
        set {
            this.ulicaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
public partial class ListaStudentowStudentListaZajecPrzedmiot {
    
    private string nazwaField;
    
    private string ocenaField;
    
    /// <remarks/>
    public string Nazwa {
        get {
            return this.nazwaField;
        }
        set {
            this.nazwaField = value;
        }
    }
    
    /// <remarks/>
    public string Ocena {
        get {
            return this.ocenaField;
        }
        set {
            this.ocenaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="mojedane")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="mojedane", IsNullable=false)]
public partial class NewDataSet {
    
    private ListaStudentow[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ListaStudentow")]
    public ListaStudentow[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
