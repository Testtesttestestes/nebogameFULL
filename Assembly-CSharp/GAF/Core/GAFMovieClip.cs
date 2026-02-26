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
		/* --- GHIDRA: setState ---
		void GAF_Core_GAFMovieClip__setState(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54eab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Core_GAFMovieClipInternal_GAFObjectsManager___ctor__);
		    DAT_ram_00a54eab = '\x01';
		  }
		  GAFInternal_Objects_GAFBakedObjectsManagerInternal_object___updateToKeyFrame
		            (param1,Method_GAFInternal_Core_GAFMovieClipInternal_GAFObjectsManager___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x0600797E RID: 31102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600797E")]
		[Address(RVA = "0xC25D", Offset = "0xC25D", VA = "0xC25D")]
		public GAFMovieClip()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		GAF_Core_GAFMovieClip___ctor(undefined4 param1,float param2,float param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a54eac == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10814);
		    DAT_ram_00a54eac = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_10814,0);
		  return 0;
		}
		*/

		}
	}
}
