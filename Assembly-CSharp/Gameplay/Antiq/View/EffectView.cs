using System;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D7D RID: 3453
	[Token(Token = "0x2000D7D")]
	[AddComponentMenu("Antiq/View/EffectView")]
	internal class EffectView : MonoBehaviour
	{
		// Token: 0x06005492 RID: 21650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005492")]
		[Address(RVA = "0x1D28", Offset = "0x1D28", VA = "0x1D28")]
		public void SetData(EffectData value, [CanBeNull] EffectData currentValue)
		{
		/* --- GHIDRA: SetData ---
		uint Gameplay_Antiq_View_EffectView__SetData(int param1,undefined4 param2)
		
		{
		  ulonglong uVar1;
		  int iVar2;
		  uint uVar3;
		  byte local_10;
		  ulonglong local_8;
		  
		  uVar3 = 0;
		  uVar1 = 0;
		  if (DAT_ram_00a587fc == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong__get_HasValue__);
		    DAT_ram_00a587fc = '\x01';
		  }
		  iVar2 = System_Linq_Enumerable__IntersectIterator___Il2CppFullySharedGenericType_
		                    (*(undefined4 *)(param1 + 8),Method_System_Linq_Enumerable_Last_ArtifactData___)
		  ;
		  if (iVar2 == *(int *)(param1 + 0x18)) {
		    if (iVar2 == 0) {
		      uVar3 = 0;
		    }
		    else {
		      local_8 = 0;
		      _local_10 = 0;
		      Core_Log_Files_FileDownloadLogger__LogDownload
		                (&local_10,*(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x20),
		                 Method_System_Nullable_ulong___ctor__);
		      uVar3 = (uint)(local_10 != 0);
		      uVar1 = local_8;
		    }
		    uVar3 = uVar3 & *(ulonglong *)(*(int *)(param1 + 0xc) + 0x20) <= uVar1;
		  }
		  return uVar3;
		}
		*/

		}

		// Token: 0x06005493 RID: 21651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005493")]
		[Address(RVA = "0x1D2A", Offset = "0x1D2A", VA = "0x1D2A")]
		public void SetIsComplete(bool value)
		{
		}

		// Token: 0x06005494 RID: 21652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005494")]
		[Address(RVA = "0xA243", Offset = "0xA243", VA = "0xA243")]
		public EffectView()
		{
		}

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_Text _currentValue;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TMP_Text _title;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_Text _value;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform[] _toHideWhenComplete;
	}
}
