using System;
using Gameplay.Isles.Base.Events;
using Gameplay.Isles.Base.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Base.Controller
{
	// Token: 0x02000CFF RID: 3327
	[Token(Token = "0x2000CFF")]
	public class BaseIsleController<TModel, TEvents> : AbstractController<TModel, TEvents> where TModel : BaseIsleModel where TEvents : BaseIsleEvents
	{
		// Token: 0x06005131 RID: 20785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005131")]
		public BaseIsleController(TModel model, TEvents events)
		{
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005132")]
		public void SetIsCurrentIsle(bool isCurrent)
		{
		}

		// Token: 0x06005133 RID: 20787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005133")]
		public override void Dispose()
		{
		}
	}
}
