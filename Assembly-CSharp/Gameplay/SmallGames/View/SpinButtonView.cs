using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.SmallGames.View
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public class SpinButtonView : MonoBehaviour
	{
		// Token: 0x14000139 RID: 313
		// (add) Token: 0x06001F4E RID: 8014 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000139")]
		public event Action<uint> AttemptsCountChangedEvent
		{
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x70B4", Offset = "0x70B4", VA = "0x70B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001F4F")]
			[Address(RVA = "0x70B5", Offset = "0x70B5", VA = "0x70B5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001F50 RID: 8016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005B9")]
		public ButtonWithCost SpinButton
		{
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x70B6", Offset = "0x70B6", VA = "0x70B6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BA")]
		public uint AttemptsCount
		{
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x70B7", Offset = "0x70B7", VA = "0x70B7")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x70B8", Offset = "0x70B8", VA = "0x70B8")]
			set
			{
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x70B9", Offset = "0x70B9", VA = "0x70B9")]
		private uint GetStep(uint currentCount)
		{
			return 0U;
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x70BA", Offset = "0x70BA", VA = "0x70BA")]
		private void Awake()
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x70BB", Offset = "0x70BB", VA = "0x70BB")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x70BC", Offset = "0x70BC", VA = "0x70BC")]
		public void Init(SlotMachineDic slotMachine)
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x70BD", Offset = "0x70BD", VA = "0x70BD")]
		public void AdjustUI(bool isFreeSpin)
		{
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x70BE", Offset = "0x70BE", VA = "0x70BE")]
		private void IncreaseCount()
		{
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x70BF", Offset = "0x70BF", VA = "0x70BF")]
		private void DecreaseCount()
		{
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x70C0", Offset = "0x70C0", VA = "0x70C0")]
		private void ShowValuePicker()
		{
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x70C1", Offset = "0x70C1", VA = "0x70C1")]
		private void PickerWindowOnSelectedEvent(uint attemptsNum)
		{
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x70C2", Offset = "0x70C2", VA = "0x70C2")]
		private void PickerWindowOnClose()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x70C3", Offset = "0x70C3", VA = "0x70C3")]
		public SpinButtonView()
		{
		}

		// Token: 0x04001106 RID: 4358
		[Token(Token = "0x4001106")]
		private const string LOCALIZATION_ATTEMPTS = "SMALL_GAMES/ATTEMPTS";

		// Token: 0x04001107 RID: 4359
		[Token(Token = "0x4001107")]
		private const string LOCALIZATION_FREE_ATTEMPTS = "SMALL_GAMES/FREE_ATTEMPTS";

		// Token: 0x04001108 RID: 4360
		[Token(Token = "0x4001108")]
		private const int CLICKS_TO_OPEN_VALUE_PICKER = 3;

		// Token: 0x04001109 RID: 4361
		[Token(Token = "0x4001109")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ButtonWithCost _spinButton;

		// Token: 0x0400110A RID: 4362
		[Token(Token = "0x400110A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _incrementButton;

		// Token: 0x0400110B RID: 4363
		[Token(Token = "0x400110B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x0400110C RID: 4364
		[Token(Token = "0x400110C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _scrollCountText;

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x24")]
		private uint _attemptsCount;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x28")]
		private SlotMachineDic _slotMachine;

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x2C")]
		private uint _min;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x30")]
		private uint _max;

		// Token: 0x04001112 RID: 4370
		[Token(Token = "0x4001112")]
		[FieldOffset(Offset = "0x34")]
		private int _changeButtonClickNum;

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		[FieldOffset(Offset = "0x38")]
		private SpinPickerDialogWindow _pickerWindow;
	}
}
