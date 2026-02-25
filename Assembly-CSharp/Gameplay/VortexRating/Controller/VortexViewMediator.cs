using System;
using Gameplay.VortexRating.Events;
using Gameplay.VortexRating.Model;
using Gameplay.VortexRating.View.VortexTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.VortexRating.Controller
{
	// Token: 0x020003A1 RID: 929
	[Token(Token = "0x20003A1")]
	public class VortexViewMediator : AbstractViewMediator<VortexRatingModel, VortexRatingEvents, VortexRatingController, VortexView>, IHideableMediator
	{
		// Token: 0x060015AA RID: 5546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AA")]
		[Address(RVA = "0x676C", Offset = "0x676C", VA = "0x676C")]
		public VortexViewMediator(VortexRatingModel model, VortexRatingEvents events, VortexRatingController controller)
		{
		}

		// Token: 0x17000392 RID: 914
		// (set) Token: 0x060015AB RID: 5547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000392")]
		public override VortexView View
		{
			[Token(Token = "0x60015AB")]
			[Address(RVA = "0x676D", Offset = "0x676D", VA = "0x676D", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AC")]
		[Address(RVA = "0x676E", Offset = "0x676E", VA = "0x676E")]
		private void InVortexButtonClickedEventHandler()
		{
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AD")]
		[Address(RVA = "0x676F", Offset = "0x676F", VA = "0x676F")]
		private void Init()
		{
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015AE")]
		[Address(RVA = "0x6770", Offset = "0x6770", VA = "0x6770", Slot = "21")]
		public void Hide()
		{
		}
	}
}
