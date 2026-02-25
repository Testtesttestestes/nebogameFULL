using System;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UI.Price;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009D1 RID: 2513
	[Token(Token = "0x20009D1")]
	public class CollectionMedalView : MonoBehaviour
	{
		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003C26 RID: 15398 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BDD")]
		public MedalView View
		{
			[Token(Token = "0x6003C26")]
			[Address(RVA = "0x8AF5", Offset = "0x8AF5", VA = "0x8AF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003C27 RID: 15399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x8AF6", Offset = "0x8AF6", VA = "0x8AF6")]
		private void Awake()
		{
		}

		// Token: 0x06003C28 RID: 15400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x8AF7", Offset = "0x8AF7", VA = "0x8AF7")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003C29 RID: 15401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x8AF8", Offset = "0x8AF8", VA = "0x8AF8")]
		public void Init(MedalData medalData, MedalDicWrapper medal, UserData user, bool showPrice)
		{
		}

		// Token: 0x06003C2A RID: 15402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x8AF9", Offset = "0x8AF9", VA = "0x8AF9")]
		private void MedalViewClickedEventHandler(MedalView view)
		{
		}

		// Token: 0x06003C2B RID: 15403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x8AFA", Offset = "0x8AFA", VA = "0x8AFA")]
		public CollectionMedalView()
		{
		}

		// Token: 0x0400213D RID: 8509
		[Token(Token = "0x400213D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Price _price;

		// Token: 0x0400213E RID: 8510
		[Token(Token = "0x400213E")]
		[FieldOffset(Offset = "0x14")]
		private MedalData _medalData;

		// Token: 0x0400213F RID: 8511
		[Token(Token = "0x400213F")]
		[FieldOffset(Offset = "0x18")]
		private UserData _user;

		// Token: 0x04002140 RID: 8512
		[Token(Token = "0x4002140")]
		[FieldOffset(Offset = "0x1C")]
		private MedalView _view;
	}
}
