using System;
using AssetContent;
using Gameplay.Clans.Controller;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.Clans.Office.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A74 RID: 2676
	[Token(Token = "0x2000A74")]
	public class ClansButtonViewMediator : AbstractViewMediator<ClansModel, ClansEvents, ClansController, ClansButtonView>
	{
		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x8E61", Offset = "0x8E61", VA = "0x8E61")]
		public ClansButtonViewMediator(ClansModel model, ClansEvents events, ClansController controller)
		{
		}

		// Token: 0x17000CA7 RID: 3239
		// (set) Token: 0x06003FA8 RID: 16296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA7")]
		public override ClansButtonView View
		{
			[Token(Token = "0x6003FA8")]
			[Address(RVA = "0x8E62", Offset = "0x8E62", VA = "0x8E62", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA8")]
		public override ClansEvents Events
		{
			[Token(Token = "0x6003FA9")]
			[Address(RVA = "0x8E63", Offset = "0x8E63", VA = "0x8E63", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAA")]
		[Address(RVA = "0x8E64", Offset = "0x8E64", VA = "0x8E64")]
		private void ButtonClickedEventHandler(GameAnimatedButton btn)
		{
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAB")]
		[Address(RVA = "0x8E65", Offset = "0x8E65", VA = "0x8E65")]
		private void UserTriggersChangedEventHandler()
		{
		}

		// Token: 0x06003FAC RID: 16300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAC")]
		[Address(RVA = "0x8E66", Offset = "0x8E66", VA = "0x8E66")]
		private void CheckRestrictions()
		{
		}

		// Token: 0x06003FAD RID: 16301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAD")]
		[Address(RVA = "0x8E67", Offset = "0x8E67", VA = "0x8E67")]
		private void ResetView()
		{
		}

		// Token: 0x06003FAE RID: 16302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FAE")]
		[Address(RVA = "0x8E68", Offset = "0x8E68", VA = "0x8E68")]
		private void SetupView()
		{
		}
	}
}
