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
	// Token: 0x020013E2 RID: 5090
	[Token(Token = "0x20013E2")]
	[AddComponentMenu("GAF/GAFMovieClip")]
	[RequireComponent(typeof(GAFObjectsManager))]
	[ExecuteInEditMode]
	public class GAFMovieClip : GAFMovieClipInternal<GAFObjectsManager>
	{
		// Token: 0x0600797D RID: 31101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797D")]
		[Address(RVA = "0xC25C", Offset = "0xC25C", VA = "0xC25C", Slot = "43")]
		protected override void setState(ref GAFObjectStateData _State, Dictionary<uint, IGAFObject> _Objects)
		{
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797E")]
		[Address(RVA = "0xC25D", Offset = "0xC25D", VA = "0xC25D")]
		public GAFMovieClip()
		{
		}
	}
}
