using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UI.Price;
using UnityEngine;

namespace Scripts.UI.Filters
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class ClampedNumberInput : MonoBehaviour
	{
		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600038E RID: 910 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600038F RID: 911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000012")]
		public event Action<long> InputChangedEvent
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x57C0", Offset = "0x57C0", VA = "0x57C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x57C1", Offset = "0x57C1", VA = "0x57C1")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000085")]
		public long CurrentValue
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x57C2", Offset = "0x57C2", VA = "0x57C2")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x57C3", Offset = "0x57C3", VA = "0x57C3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x57C4", Offset = "0x57C4", VA = "0x57C4")]
		private void Awake()
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x57C5", Offset = "0x57C5", VA = "0x57C5")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x57C6", Offset = "0x57C6", VA = "0x57C6")]
		public void SetMaxValue(long maxValue)
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x57C7", Offset = "0x57C7", VA = "0x57C7")]
		public void Init(string iconAssetId)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C73", Offset = "0x1C73", VA = "0x1C73")]
		public void UpdateUpperBound(long maxValue)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C71", Offset = "0x1C71", VA = "0x1C71")]
		public void UpdateLowerBound(long minValue)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C75", Offset = "0x1C75", VA = "0x1C75")]
		public void SetValue(long value)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x57C8", Offset = "0x57C8", VA = "0x57C8")]
		private void OnValueChangedHandler(string str)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x57C9", Offset = "0x57C9", VA = "0x57C9")]
		private void ValidateInput()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x57CA", Offset = "0x57CA", VA = "0x57CA")]
		public ClampedNumberInput()
		{
		}

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private PriceItemRenderer _validationRenderer;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x20")]
		private long _maxValue;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x28")]
		private long _lowerBound;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x30")]
		private long _upperBound;
	}
}
