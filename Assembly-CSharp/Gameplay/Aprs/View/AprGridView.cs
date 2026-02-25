using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI;
using UI.Price;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4E RID: 3406
	[Token(Token = "0x2000D4E")]
	public class AprGridView : AbstractDataRenderer<AprData>
	{
		// Token: 0x140001FC RID: 508
		// (add) Token: 0x06005367 RID: 21351 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005368 RID: 21352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001FC")]
		public static event Action<AprGridView> SelectEvent
		{
			[Token(Token = "0x6005367")]
			[Address(RVA = "0xA126", Offset = "0xA126", VA = "0xA126")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005368")]
			[Address(RVA = "0xA127", Offset = "0xA127", VA = "0xA127")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170010F0 RID: 4336
		// (get) Token: 0x06005369 RID: 21353 RVA: 0x0000F168 File Offset: 0x0000D368
		[Token(Token = "0x170010F0")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6005369")]
			[Address(RVA = "0xA128", Offset = "0xA128", VA = "0xA128", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536A")]
		[Address(RVA = "0xA129", Offset = "0xA129", VA = "0xA129", Slot = "9")]
		protected override void Awake()
		{
		}

		// Token: 0x0600536B RID: 21355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536B")]
		[Address(RVA = "0xA12A", Offset = "0xA12A", VA = "0xA12A", Slot = "10")]
		public override void Dispose()
		{
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536C")]
		[Address(RVA = "0xA12B", Offset = "0xA12B", VA = "0xA12B")]
		private void AprViewOnClickEvent(AprView aprView)
		{
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536D")]
		[Address(RVA = "0xA12C", Offset = "0xA12C", VA = "0xA12C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536E")]
		[Address(RVA = "0xA12D", Offset = "0xA12D", VA = "0xA12D")]
		private void HandlePrice([NotNull] AprData aprData)
		{
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600536F")]
		[Address(RVA = "0xA12E", Offset = "0xA12E", VA = "0xA12E", Slot = "17")]
		protected override void StartListenEvents(AprData data)
		{
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005370")]
		[Address(RVA = "0xA12F", Offset = "0xA12F", VA = "0xA12F", Slot = "18")]
		protected override void StopListenEvents(AprData data)
		{
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005371")]
		[Address(RVA = "0xA130", Offset = "0xA130", VA = "0xA130")]
		private void HandleCurrentMedalChangedEvent(MedalDicWrapper from, MedalDicWrapper to)
		{
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005372")]
		[Address(RVA = "0xA131", Offset = "0xA131", VA = "0xA131")]
		private void HandleCurrentMedalWrapperDataChangedEvent()
		{
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005373")]
		[Address(RVA = "0xA132", Offset = "0xA132", VA = "0xA132")]
		public AprGridView()
		{
		}

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected AprView _aprView;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected Price _price;
	}
}
