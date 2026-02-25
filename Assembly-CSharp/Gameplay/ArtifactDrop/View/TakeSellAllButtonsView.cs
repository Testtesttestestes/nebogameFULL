using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.ArtifactDrop.View
{
	// Token: 0x02000CC7 RID: 3271
	[Token(Token = "0x2000CC7")]
	public class TakeSellAllButtonsView : MonoBehaviour
	{
		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001024")]
		public Button TakeAllBtn
		{
			[Token(Token = "0x6004FA0")]
			[Address(RVA = "0x9DB9", Offset = "0x9DB9", VA = "0x9DB9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001025 RID: 4133
		// (get) Token: 0x06004FA1 RID: 20385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001025")]
		public Button SellAllBtn
		{
			[Token(Token = "0x6004FA1")]
			[Address(RVA = "0x9DBA", Offset = "0x9DBA", VA = "0x9DBA")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FA2")]
		[Address(RVA = "0x9DBB", Offset = "0x9DBB", VA = "0x9DBB")]
		public TakeSellAllButtonsView()
		{
		}

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _takeAllBtn;

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4002B62")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _sellAllBtn;
	}
}
