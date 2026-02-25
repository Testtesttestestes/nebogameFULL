using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace AssetContent.Loaders
{
	// Token: 0x02000E30 RID: 3632
	[Token(Token = "0x2000E30")]
	[DisallowMultipleComponent]
	public class GameImageLoader : AbstractGameGraphicLoader<Image, Sprite>
	{
		// Token: 0x060058FF RID: 22783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FF")]
		[Address(RVA = "0xA653", Offset = "0xA653", VA = "0xA653", Slot = "11")]
		public override void SetAsset(Sprite asset)
		{
		}

		// Token: 0x06005900 RID: 22784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005900")]
		[Address(RVA = "0xA654", Offset = "0xA654", VA = "0xA654", Slot = "12")]
		public override void ReleaseAsset(string url)
		{
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005901")]
		[Address(RVA = "0xA655", Offset = "0xA655", VA = "0xA655", Slot = "13")]
		public override void LoadAsset(string url, Action<Sprite, string> successCallback, Action<string> failCallback, bool saveOnDisk)
		{
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005902")]
		[Address(RVA = "0xA656", Offset = "0xA656", VA = "0xA656")]
		public GameImageLoader()
		{
		}
	}
}
