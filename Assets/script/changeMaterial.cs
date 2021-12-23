using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class changeMaterial : MonoBehaviour {
    public Material[] materials;
    public bool temTexto = false;
    Text campoTexto;
    Renderer rend;
    public int idCurso = 1;
    //Material material;
    // Use this for initialization
    void Start ()
    {
        idCurso = PlayerPrefs.GetInt("Codigo") - 1;
        if (!temTexto)
        {
            rend = GetComponent<Renderer>();
            rend.sharedMaterial = materials[idCurso];
        }
        else
        {
            campoTexto = GetComponent<Text>();
            if (idCurso == 0)
            {
                campoTexto.text = "Conheça a estrutura de distribuição de energia elétrica no Brasil e aprenda a utilizar esse recurso de maneira eficiente e responsável no <b>curso 100% online e gratuito</b> de <b>Consumo Consciente de Energia!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você estará apto a tornar o <b>consumo de energia elétrica em seu ambiente mais eficiente</b>, sabendo de onde vem a energia elétrica utilizada, quais os impactos da geração de energia e quais são as formas de reduzir estes impactos, <b>tornando o consumo mais sustentável.</b>";
            }
            if (idCurso == 1)
            {
                campoTexto.text = "Não perca a oportunidade de conhecer as normas, as principais técnicas e a história dos projetos de arquitetura para se familiarizar com os materiais e representações gráficas de estruturas e dar os primeiros passos em uma carreira na Construção Civil com o <b>curso 100% online e gratuito</b> de <b>Desenho Arquitetônico!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Este curso irá introduzi-lo as noções básicas referentes a <b>representação gráfica de construção civil</b>, para que estes possam verificar suas aptidões ou não no seguimento de uma carreira na <b>Área de Construção Civil.</b>";
            }
            if (idCurso == 2)
            {
                campoTexto.text = "Aprenda sobre as origens do movimento ambientalista, descubra as políticas públicas ambientais brasileiras e conheça novas formas de contribuir para a preservação do meio ambiente com o <b>curso 100% online e gratuito</b> em <b>Educação Ambiental!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Este curso tenta sensibilizar você para as <b>questões básicas da educação ambiental</b>, de forma a criar uma mentalidade prevencionista, com relação ao meio ambiente.";
            }
            if (idCurso == 3)
            {
                campoTexto.text = "Descubra o papel dos empreendedores na economia nacional, aprenda a identificar oportunidades e conheça o que é necessário para tirar o seu projeto do papel com o <b>curso 100% online e gratuito</b> em Empreendedorismo!";
                campoTexto.text += "\n\n";
                campoTexto.text += "Este curso tem por objetivo oferecer conhecimentos sobre o ato de <b>criação de novos empreendimentos</b> nos mais diversos setores, propiciando, em especial:";
                campoTexto.text += "\n\n";
                campoTexto.text += " - O conhecimento sobre a <b>importância do empreendedorismo</b> para a economia, sua importância na geração de emprego e renda;";
                campoTexto.text += "\n";
                campoTexto.text += " - O universo das <b>ações empreendedoras</b> que vão desde abertura de empresas com propósito econômico e financeiro, bem como com objetivos puramente sociais;";
                campoTexto.text += "\n";
                campoTexto.text += " - A promoção da <b>cultura empreendedora</b> dentro das empresas por meio de ações de empreendedorismo corporativo;";
                campoTexto.text += "\n";
                campoTexto.text += " - A compreensão da importância da <b>inovação e sustentabilidade</b> e que se almejamos nos tornarmos uma das maiores economias do mundo somente podemos alcançar por meio de uma nação empreendedora.";
            }
            if (idCurso == 4)
            {
                campoTexto.text = "Aprenda a controlar as suas próprias finanças, planejando o seu orçamento e fazendo investimentos para proteger o seu patrimônio em situações imprevistas e nas eventuais crises econômicas nesse <b>curso 100% online e gratuito</b> em <b>Finanças Pessoais!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você entenderá a <b>importância do equilíbrio financeiro</b> para obter mais qualidade de vida, tranquilidade e motivação.";
            }
            if (idCurso == 5)
            {
                campoTexto.text = "Descubra o que é necessário para administrar o patrimônio e os recursos de uma empresa, conhecendo a história, os principais conceitos e definições da área com o <b>curso 100% online e gratuito</b> em <b>Fundamentos de Logística!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você entenderá as questões fundamentais da logística, seu histórico, conceitos, e de <b>como utilizar melhor a logística</b> num ambiente empresarial envolvido no mercado globalizado";
            }
            if (idCurso == 6)
            {
                campoTexto.text = "Descubra as dinâmicas sociais, conheça os aspectos legais e aprenda quais são os direitos e as responsabilidades dos trabalhadores e seus empregadores com o <b>curso 100% online e gratuito</b> em <b>Legislação Trabalhista!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você aprenderá a identificar os dispositivos legais que regulamentam as <b>relações de trabalho.</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Esse curso é para estudantes dos cursos de educação profissional, do ensino médio, dos últimos anos do ensino fundamental, da educação de jovens e adultos e do ensino superior que estejam iniciando sua preparação para o mundo do trabalho.";
            }
            if (idCurso == 7)
            {
                campoTexto.text = "Dê os primeiros passos no desenvolvimento de programas para computadores, conhecendo os principais tipos de variáveis e os conceitos fundamentais que estão por trás da criação de rotinas de automação com o <b>curso 100% online e gratuito</b> em <b>Lógica de Programação!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você aprenderá os <b>conceitos básicos sobre lógica de programação</b>, tipos de dados, estruturas de controle e repetição.";
                campoTexto.text += "\n\n";
                campoTexto.text += "Além de ver exemplos do uso de variáveis homogêneas e heterogêneas";
            }
            if (idCurso == 8)
            {
                campoTexto.text = "Entenda quais são os principais tipos, unidades, equipamentos e técnicas de mensuração e obtenha os conhecimentos que são fundamentais para uma carreira na área da Mecânica com o <b>curso 100% online e gratuito</b> em <b>Metrologia!</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você irá adquirir o conhecimento básico necessário à <b>aplicação e interpretação das medidas</b> na área da mecânica. O curso tem como objetivo explorar os principais temas relacionados a metrologia desde os instrumentos mais básicos como as réguas até instrumentos com um grau maior de precisão.";
            }
            if (idCurso == 9)
            {
                campoTexto.text = "Descubra quais são os principais componentes e aprenda como funcionam os automóveis, conhecendo as forças físicas envolvidas e os mecanismos por trás do funcionamento dos veículos automotores com o <b>curso 100% online e gratuito</b> em <b>Noções Básicas de Mecânica Automotiva.</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você irá adquirir o conhecimento necessário à aplicação e <b>interpretação de conceitos físicos e mecânicos</b>, relacionados à área de mecânica automotiva.";
            }
            if (idCurso == 10)
            {
                campoTexto.text = "Conheça os principais tipos de propriedade intelectual, descubra a sua importância e aprenda a proteger as suas ideias, inovações e criações com o <b>curso 100% online e gratuito</b> em <b>Propriedade Intelectual.</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você estará apto identificar a importância da Propriedade Intelectual e dos benefícios da <b>proteção dos produtos derivados da criatividade e da inovação.</b>";
            }
            if (idCurso == 11)
            {
                campoTexto.text = "Descubra quais são os principais riscos à saúde e à segurança dos trabalhadores, aprenda as técnicas de primeiros socorros e diferencie-se em qualquer profissão com o <b>curso 100% online e gratuito</b> em <b>Segurança do Trabalho.</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você compreenderá as <b>questões relativas à Segurança, Meio Ambiente e Saúde</b> de modo a possibilitar uma visão crítica dos riscos e perigos existentes no mundo do trabalho.";
            }
            if (idCurso == 12)
            {
                campoTexto.text = "Valorize a sua qualificação profissional aprofundando os seus conhecimentos e descobrindo a história, os conceitos e a importância das tecnologias digitais com o <b>curso 100% online e gratuito</b> em <b>Tecnologia da Informação e Comunicação.</b>";
                campoTexto.text += "\n\n";
                campoTexto.text += "Você compreenderá quais os <b>processos de TIC são utilizados no cotidiano profissional</b> e qual a sua relevância na carreira do jovem que ingressa no mercado de trabalho.";
            }
        }

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
