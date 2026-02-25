using System;
using Core.Data;
using Gameplay.Isles.Axis.Events;
using Gameplay.Isles.Axis.Model;
using Gameplay.Isles.Axis.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.Axis.Controller
{
	// Token: 0x02000D0A RID: 3338
	[Token(Token = "0x2000D0A")]
	public class AxisIsleViewMediator : AbstractViewMediator<AxisIsleModel, AxisIsleEvents, AxisIsleController, AxisIsleView>
	{
		// Token: 0x0600516E RID: 20846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600516E")]
		[Address(RVA = "0x9F4D", Offset = "0x9F4D", VA = "0x9F4D")]
		public AxisIsleViewMediator(AxisIsleModel model, AxisIsleEvents events, AxisIsleController controller)
		{
		}

		// Token: 0x1700107C RID: 4220
		// (set) Token: 0x0600516F RID: 20847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107C")]
		public override AxisIsleView View
		{
			[Token(Token = "0x600516F")]
			[Address(RVA = "0x9F4E", Offset = "0x9F4E", VA = "0x9F4E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005170 RID: 20848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005170")]
		[Address(RVA = "0x9F4F", Offset = "0x9F4F", VA = "0x9F4F")]
		private void ResetView()
		{
		}

		// Token: 0x06005171 RID: 20849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005171")]
		[Address(RVA = "0x9F50", Offset = "0x9F50", VA = "0x9F50")]
		private void SetupView()
		{
		}

		// Token: 0x06005172 RID: 20850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005172")]
		[Address(RVA = "0x9F51", Offset = "0x9F51", VA = "0x9F51")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		}

		// Token: 0x06005173 RID: 20851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005173")]
		[Address(RVA = "0x9F52", Offset = "0x9F52", VA = "0x9F52")]
		private void BgClickedEventHandler()
		{
		}

		// Token: 0x1700107D RID: 4221
		// (set) Token: 0x06005174 RID: 20852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700107D")]
		public override AxisIsleEvents Events
		{
			[Token(Token = "0x6005174")]
			[Address(RVA = "0x9F53", Offset = "0x9F53", VA = "0x9F53", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06005175 RID: 20853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005175")]
		[Address(RVA = "0x9F54", Offset = "0x9F54", VA = "0x9F54")]
		private void IsleInformationChangedEventHandler()
		{
		}

		// Token: 0x06005176 RID: 20854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005176")]
		[Address(RVA = "0x9F55", Offset = "0x9F55", VA = "0x9F55")]
		private void UpdateColossus()
		{
		}
	}
}
