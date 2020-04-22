using System.ComponentModel.DataAnnotations;

namespace PomodoroBlazor.Model
{
    public class ConfiguracoesPomodoro
    {
        [Required(ErrorMessage = "Especificar tempo de duração Pomodoro")]
        [Range(1,60,ErrorMessage = "Intervalo de tempo deve ser entre 1 e 60")]
        public int DuracaoCiclo { get; set; }

        [Range(1, 15, ErrorMessage = "Intervalo curto deve ser entre 1 e 15")]
        public int IntervaloCurto { get; set; }

        [Range(15, 60, ErrorMessage = "Intervalo longo deve ser entre 15 e 60")]
        public int IntervaloLongo { get; set; }
    }

    public enum TipoTimer
    {
        Pomodoro = 1,
        IntervaloCurto = 2,
        IntervaloLongo = 3
    }
}
