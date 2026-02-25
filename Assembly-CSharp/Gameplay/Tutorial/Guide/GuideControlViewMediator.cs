using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Control;
using Gameplay.Tutorial.Guide.Model;
using Gameplay.Tutorial.Guide.View.Control;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tutorial.Guide
{
	// Token: 0x02000455 RID: 1109
	[Token(Token = "0x2000455")]
	public class GuideControlViewMediator : AbstractViewMediator<GuideModel, GuideEvents, GuideController, GuideControlView>
	{
		// Token: 0x06001A45 RID: 6725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x6BDC", Offset = "0x6BDC", VA = "0x6BDC")]
		public GuideControlViewMediator(GuideModel model, GuideEvents events, GuideController controller)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001A47 RID: 6727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		public override GuideEvents Events
		{
			[Token(Token = "0x6001A46")]
			[Address(RVA = "0x6BDD", Offset = "0x6BDD", VA = "0x6BDD", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001A47")]
			[Address(RVA = "0x6BDE", Offset = "0x6BDE", VA = "0x6BDE", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700049B RID: 1179
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049B")]
		public override GuideControlView View
		{
			[Token(Token = "0x6001A48")]
			[Address(RVA = "0x6BDF", Offset = "0x6BDF", VA = "0x6BDF", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A49")]
		[Address(RVA = "0x6BE0", Offset = "0x6BE0", VA = "0x6BE0")]
		private void SetupView()
		{
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4A")]
		[Address(RVA = "0x6BE1", Offset = "0x6BE1", VA = "0x6BE1")]
		private void HandleGuideToggle()
		{
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001A4B")]
		[Address(RVA = "0x6BE2", Offset = "0x6BE2", VA = "0x6BE2")]
		private void ValidateState()
		{
		}
	}
}
