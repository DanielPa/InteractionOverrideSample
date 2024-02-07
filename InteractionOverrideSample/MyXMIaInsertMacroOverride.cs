using Eplan.EplApi.Base;
using Eplan.EplApi.EServices.Ged;

namespace InteractionOverrideSample
{
  [Interaction(Name = "XMIaInsertMacro", NameOfBaseInteraction = "XMIaInsertMacro", Ordinal = 50, Prio = 20)]
  public class MyXmIaInsertMacroOverride : InsertInteraction
  {
    public override RequestCode OnStart(InteractionContext oContext)
    {
      new BaseException($"{nameof(MyXmIaInsertMacroOverride)} - {nameof(OnStart)}", MessageLevel.Message).FixMessage();
      return base.OnStart(oContext);
    }

    public override void OnSuccess(InteractionContext result)
    {
      new BaseException($"{nameof(MyXmIaInsertMacroOverride)} - {nameof(OnSuccess)}", MessageLevel.Message).FixMessage();
      base.OnSuccess(result);
    }
  }
}