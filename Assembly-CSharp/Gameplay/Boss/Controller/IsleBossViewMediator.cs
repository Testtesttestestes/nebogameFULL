using System;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.WorldView;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Boss.Controller
{
	// Token: 0x02000BBD RID: 3005
	[Token(Token = "0x2000BBD")]
	public class IsleBossViewMediator : AbstractViewMediator<BossInstanceModel, BossInstanceEvents, BossInstanceController, IsleBossView>
	{
		// Token: 0x060049B8 RID: 18872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049B8")]
		[Address(RVA = "0x982A", Offset = "0x982A", VA = "0x982A")]
		public IsleBossViewMediator(BossInstanceModel model, BossInstanceEvents events, BossInstanceController controller)
		{
		}

		// Token: 0x17000EE3 RID: 3811
		// (set) Token: 0x060049B9 RID: 18873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE3")]
		public override BossInstanceEvents Events
		{
			[Token(Token = "0x60049B9")]
			[Address(RVA = "0x982B", Offset = "0x982B", VA = "0x982B", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BA")]
		[Address(RVA = "0x982C", Offset = "0x982C", VA = "0x982C")]
		private void HealthChangedEvent()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BB")]
		[Address(RVA = "0x982D", Offset = "0x982D", VA = "0x982D")]
		private void InstanceStateChangedEvent()
		{
		}

		// Token: 0x17000EE4 RID: 3812
		// (set) Token: 0x060049BC RID: 18876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EE4")]
		public override IsleBossView View
		{
			[Token(Token = "0x60049BC")]
			[Address(RVA = "0x982E", Offset = "0x982E", VA = "0x982E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BD")]
		[Address(RVA = "0x982F", Offset = "0x982F", VA = "0x982F")]
		private void ShowCurrentState()
		{
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BE")]
		[Address(RVA = "0x9830", Offset = "0x9830", VA = "0x9830")]
		private void ViewOnClickEvent()
		{
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049BF")]
		[Address(RVA = "0x9831", Offset = "0x9831", VA = "0x9831", Slot = "14")]
		public override void Dispose()
		{
		}
	}
}
