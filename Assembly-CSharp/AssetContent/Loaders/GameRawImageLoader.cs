using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AssetContent.Loaders
{
	// Token: 0x02000E32 RID: 3634
	[Token(Token = "0x2000E32")]
	[DisallowMultipleComponent]
	public class GameRawImageLoader : AbstractGameGraphicLoader<RawImage, Texture2D>
	{
		// Token: 0x06005906 RID: 22790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005906")]
		[Address(RVA = "0xA65A", Offset = "0xA65A", VA = "0xA65A", Slot = "11")]
		public override void SetAsset(Texture2D asset)
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005907")]
		[Address(RVA = "0xA65B", Offset = "0xA65B", VA = "0xA65B", Slot = "12")]
		public override void ReleaseAsset(string url)
		{
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005908")]
		[Address(RVA = "0xA65C", Offset = "0xA65C", VA = "0xA65C", Slot = "13")]
		public override void LoadAsset(string url, Action<Texture2D, string> successCallback, Action<string> failCallback, bool saveOnDisk)
		{
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005909")]
		[Address(RVA = "0xA65D", Offset = "0xA65D", VA = "0xA65D")]
		public GameRawImageLoader()
		{
		}
	}
}
