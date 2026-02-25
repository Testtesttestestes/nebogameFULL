using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000786 RID: 1926
	[Token(Token = "0x2000786")]
	public class LoaderTagView : MonoBehaviour
	{
		// Token: 0x06002DCD RID: 11725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCD")]
		[Address(RVA = "0x7E4B", Offset = "0x7E4B", VA = "0x7E4B")]
		public void Load(string assetId)
		{
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DCE")]
		[Address(RVA = "0x7E4C", Offset = "0x7E4C", VA = "0x7E4C")]
		public LoaderTagView()
		{
		}

		// Token: 0x04001921 RID: 6433
		[Token(Token = "0x4001921")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _customLoader;
	}
}
