using System;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;

namespace Gameplay.Combat.Control
{
	// Token: 0x020009BC RID: 2492
	[Token(Token = "0x20009BC")]
	public class OneOnOneCombatViewMediator<TModel, TEvents, TController> : AbstractOneOnOneCombatViewMediator<TModel, TEvents, TController, OneOnOneCombatView> where TModel : CombatModel where TEvents : CombatEvents where TController : CombatController<TModel, TEvents>
	{
		// Token: 0x06003BB6 RID: 15286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BB6")]
		public OneOnOneCombatViewMediator(TModel model, TEvents events, TController controller)
		{
		}
	}
}
