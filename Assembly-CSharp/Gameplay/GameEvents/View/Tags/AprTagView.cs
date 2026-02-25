using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class AprTagView : AprView
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00008D18 File Offset: 0x00006F18
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CB")]
		public uint MedalId
		{
			[Token(Token = "0x6002DC1")]
			[Address(RVA = "0x7E3F", Offset = "0x7E3F", VA = "0x7E3F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002DC2")]
			[Address(RVA = "0x7E40", Offset = "0x7E40", VA = "0x7E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CC")]
		public string AssetId
		{
			[Token(Token = "0x6002DC3")]
			[Address(RVA = "0x7E41", Offset = "0x7E41", VA = "0x7E41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DC4")]
			[Address(RVA = "0x7E42", Offset = "0x7E42", VA = "0x7E42")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x7E43", Offset = "0x7E43", VA = "0x7E43", Slot = "27")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x7E44", Offset = "0x7E44", VA = "0x7E44", Slot = "26")]
		protected override void SetAsset(AprDicWrapper data)
		{
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x7E45", Offset = "0x7E45", VA = "0x7E45", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x7E46", Offset = "0x7E46", VA = "0x7E46")]
		public AprTagView()
		{
		}
	}
}
