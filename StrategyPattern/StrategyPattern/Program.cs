using StrategyPattern;

BorrachoStrategyContext oBorracho = new BorrachoStrategyContext();
oBorracho.Conquistar(BorrachoStrategyContext.Comportamiento.HacerOjitos);
oBorracho.Conquistar(BorrachoStrategyContext.Comportamiento.InvitarCerveza);
oBorracho.Conquistar(BorrachoStrategyContext.Comportamiento.HacerDeGalan);