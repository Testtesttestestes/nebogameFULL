using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScreenAdaptation.Scale
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	public class SceneScalableContent : MonoBehaviour
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x5AF8", Offset = "0x5AF8", VA = "0x5AF8")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x5AF9", Offset = "0x5AF9", VA = "0x5AF9")]
		private void Start()
		{
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x5AFA", Offset = "0x5AFA", VA = "0x5AFA")]
		public SceneScalableContent()
		{
		}

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera[] _cameras;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Canvas[] _canvases;
	}
}
