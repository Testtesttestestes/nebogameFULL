using System;
using System.Collections;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC5 RID: 2757
	[Token(Token = "0x2000AC5")]
	public class GolemInventoryChestWindow : InventoryChestWindow
	{
		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600427B RID: 17019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D17")]
		public override string WindowId
		{
			[Token(Token = "0x600427B")]
			[Address(RVA = "0x912F", Offset = "0x912F", VA = "0x912F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600427C RID: 17020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427C")]
		[Address(RVA = "0x9130", Offset = "0x9130", VA = "0x9130")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600427D RID: 17021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427D")]
		[Address(RVA = "0x9131", Offset = "0x9131", VA = "0x9131", Slot = "24")]
		protected override void Awake()
		{
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600427E")]
		[Address(RVA = "0x9132", Offset = "0x9132", VA = "0x9132")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x9133", Offset = "0x9133", VA = "0x9133")]
		public GolemInventoryChestWindow()
		{
		}

		// Token: 0x040024AD RID: 9389
		[Token(Token = "0x40024AD")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/GolemInventoryWindow";

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[FieldOffset(Offset = "0x54")]
		private GolemInventoryViewMediator _mediator;
	}
}
