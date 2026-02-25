using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.Inventory.Model;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Gameplay.Inventory.Controller.Middlewares
{
	// Token: 0x020006C1 RID: 1729
	[Token(Token = "0x20006C1")]
	public abstract class InventoryActionsMiddlewareBase<M> where M : InventoryBaseModel
	{
		// Token: 0x060029D5 RID: 10709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029D5")]
		public InventoryActionsMiddlewareBase(M model, UserData owner)
		{
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E3")]
		public M Model
		{
			[Token(Token = "0x60029D6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029D7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E4")]
		public UserData Owner
		{
			[Token(Token = "0x60029D8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029D9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x60029DA")]
		public UniTask<int> StartResolveEquipProcess(ArtifactData artifact)
		{
			return default(UniTask<int>);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029DB")]
		public OpToken<int, int> StartResolveEquipFromDropProcess(ArtifactData artifact)
		{
			return null;
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029DC")]
		public OpToken<int, int> StartResolveEmptySlotsProcess(int count, InvetoryScope scope)
		{
			return null;
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60029DD")]
		public DialogWindow ShowNotAvailableSlotsWindow(long slotsCount)
		{
			return null;
		}

		// Token: 0x060029DE RID: 10718
		[Token(Token = "0x60029DE")]
		protected abstract OpToken<int, int> ShowInventoryConfirmBuySlotWindow(InvetoryScope scope, uint needCount);

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x0")]
		private OpTokenStorage<string, int, int> _opTokenStorage;
	}
}
