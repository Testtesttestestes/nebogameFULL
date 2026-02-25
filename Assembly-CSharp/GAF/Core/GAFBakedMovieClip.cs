using System;
using System.Collections.Generic;
using GAF.Objects;
using GAFInternal.Core;
using GAFInternal.Data;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Core
{
	// Token: 0x020013E1 RID: 5089
	[Token(Token = "0x20013E1")]
	[AddComponentMenu("GAF/GAFBakedMovieClip")]
	[RequireComponent(typeof(GAFBakedObjectsManager))]
	[ExecuteInEditMode]
	public class GAFBakedMovieClip : GAFMovieClipInternal<GAFBakedObjectsManager>
	{
		// Token: 0x0600797B RID: 31099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797B")]
		[Address(RVA = "0xC25A", Offset = "0xC25A", VA = "0xC25A", Slot = "43")]
		protected override void setState(ref GAFObjectStateData _State, Dictionary<uint, IGAFObject> _Objects)
		{
		}

		// Token: 0x0600797C RID: 31100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797C")]
		[Address(RVA = "0xC25B", Offset = "0xC25B", VA = "0xC25B")]
		public GAFBakedMovieClip()
		{
		}
	}
}
