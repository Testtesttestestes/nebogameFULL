using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace UI.ValuePicker
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public class ValuePickerOsaSpinner : OSA<ValuePickerOsaParams, ValuePickerOsaViewHolder>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		public SimpleDataHelper<string> Data
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x5C62", Offset = "0x5C62", VA = "0x5C62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x5C63", Offset = "0x5C63", VA = "0x5C63")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000035A0 File Offset: 0x000017A0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		public int CurrentSelectedIndex
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x5C64", Offset = "0x5C64", VA = "0x5C64")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x5C65", Offset = "0x5C65", VA = "0x5C65")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CF")]
		public event Action<int> CurrentSelectedIndexChangedEvent
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x5C66", Offset = "0x5C66", VA = "0x5C66")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x5C67", Offset = "0x5C67", VA = "0x5C67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x5C68", Offset = "0x5C68", VA = "0x5C68", Slot = "67")]
		protected override void Awake()
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5C69", Offset = "0x5C69", VA = "0x5C69", Slot = "70")]
		protected override void Update()
		{
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x5C6A", Offset = "0x5C6A", VA = "0x5C6A")]
		private void OnItemSelected(int index)
		{
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x5C6B", Offset = "0x5C6B", VA = "0x5C6B", Slot = "99")]
		protected override ValuePickerOsaViewHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x5C6C", Offset = "0x5C6C", VA = "0x5C6C", Slot = "100")]
		protected override void UpdateViewsHolder(ValuePickerOsaViewHolder newOrRecycled)
		{
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x5C6D", Offset = "0x5C6D", VA = "0x5C6D")]
		public ValuePickerOsaSpinner()
		{
		}
	}
}
