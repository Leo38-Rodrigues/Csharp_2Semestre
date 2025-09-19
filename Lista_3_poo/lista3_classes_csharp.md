![senai_logo](https://transparencia.sp.senai.br/Content/img/logo-senai.png)

# Lista de exercícios 03: Classes C#

Profº.: Cainã Antunes Silva  
Faculdade de Tecnologia **SENAI Sorocaba**  
Tecnólogo em Análise e Desenvolvimento de Sistemas (ADS)
___


> O objetivo desta lista de exercícios é praticar o uso das Classes C# disponíveis no namespace system. Além disso esta atividade ajudará a compreender o funcionamento de classes estáticas e finais.  

O reaproveitamento de código é essencial no desenvolvimeto de aplicações complexas, portanto é fundamental conhecer algumas ferramentas  básicas disponibilizadas pela comunicadade de desenvolvedores através de softwares e bibliotecas de código aberto, bem como saber interpretar suas documentações.

Para mais informações acesse [Aula 04: Classes CSharp.](https://cainaantunes.notion.site/Aula-04-Classes-CSharp-245bde521b3b80ea8417d63cdb836d14?source=copy_link)

***

1. **Projeto:** Conversor de Temperatura
    <br>
    Você foi contratado para desenvolver uma pequena biblioteca de utilidades que permita a conversão entre diferentes unidades de temperatura.
    <br>
    > Crie uma aplicação Console em C# que permita ao usuário converter temperaturas entre Celsius, Fahrenheit e Kelvin.
    <br>
    
    O sistema deverá atender aos seguintes requisitos:
    
    1. A classe deve se chamar `TemperatureConverter`.
    2. A classe deve ser estática, pois não faz sentido criar instâncias para ela.
    3. Devem existir métodos para conversão entre todas as principais escalas de temperatura: Celsius (°C), Fahrenheit (°F) e Kelvin (K).
    4. Cada método deverá ser público e estático e receber um valor `double` como parâmetro, retornando também um `double`.
    <br>
    **Diagrama de Classes:**
        ```mermaid
            classDiagram
            class TemperatureConverter {
                <<static>>
                + CelsiusToFahrenheit(celsius : double) : double
                + CelsiusToKelvin(celsius : double) : double
                + FahrenheitToCelsius(fahrenheit : double) : double
                + FahrenheitToKelvin(fahrenheit : double) : double
                + KelvinToCelsius(kelvein : double) : double
                + KelvinToFahrenheit(kelvin : double) : double
            }
        ```
    
    **Fundamentos teóricos:**
 
 ![Escalas de temperatura](https://static.mundoeducacao.uol.com.br/mundoeducacao/2023/09/escalas-termometricas.jpg)

 $$
    \frac{C}{5}=\frac{F-32}{9}=\frac{K-273}{5}
 $$
***