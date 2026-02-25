using System;
using AssetContent;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Collections.View
{
	// Token: 0x020009CF RID: 2511
	[Token(Token = "0x20009CF")]
	public class CollectionAprView : AprView
	{
		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDC")]
		public AprView View
		{
			[Token(Token = "0x6003C1F")]
			[Address(RVA = "0x8AEE", Offset = "0x8AEE", VA = "0x8AEE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C20 RID: 15392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C20")]
		[Address(RVA = "0x8AEF", Offset = "0x8AEF", VA = "0x8AEF")]
		public void Init(CollectionsModel.AprMaterial data, UserData user, bool sameUser)
		{
		}

		// Token: 0x06003C21 RID: 15393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x8AF0", Offset = "0x8AF0", VA = "0x8AF0", Slot = "26")]
		protected override void SetAsset(AprDicWrapper data)
		{
		}

		// Token: 0x06003C22 RID: 15394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x8AF1", Offset = "0x8AF1", VA = "0x8AF1")]
		public CollectionAprView()
		{
		}

		// Token: 0x04002136 RID: 8502
		[Token(Token = "0x4002136")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameRawImage _rankFrame;

		// Token: 0x04002137 RID: 8503
		[Token(Token = "0x4002137")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _frameBgImage;

		// Token: 0x04002138 RID: 8504
		[Token(Token = "0x4002138")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Price _price;

		// Token: 0x04002139 RID: 8505
		[Token(Token = "0x4002139")]
		[FieldOffset(Offset = "0x68")]
		private AprView _view;
	}
}
