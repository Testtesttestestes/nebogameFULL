using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Localization.Culture
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public abstract class BaseCultureProvider
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DA")]
		public SystemLanguage Language
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x5B66", Offset = "0x5B66", VA = "0x5B66")]
			[CompilerGenerated]
			get
			{
				return SystemLanguage.Afrikaans;
			}
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x5B67", Offset = "0x5B67", VA = "0x5B67")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5B68", Offset = "0x5B68", VA = "0x5B68")]
		protected BaseCultureProvider(SystemLanguage language)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5B69", Offset = "0x5B69", VA = "0x5B69", Slot = "4")]
		public virtual void SetLanguage(SystemLanguage value)
		{
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1AEA", Offset = "0x1AEA", VA = "0x1AEA")]
		public CultureInfo GetCulture()
		{
		/* --- GHIDRA: GetCulture ---
		undefined4 Localization_Culture_BaseCultureProvider__GetCulture(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a575fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Single_RefAccountInfo___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid_b__20_0__);
		    Mono_Security_ASN1__get_Item(&System_Func_RefAccountInfo__bool__TypeInfo);
		    DAT_ram_00a575fd = '\x01';
		  }
		  if (*(int *)(param1 + 8) == 0) {
		    uVar2 = 0;
		  }
		  else {
		    param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x50);
		    uVar2 = unnamed_function_1417(System_Func_RefAccountInfo__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar2,param1,Method_Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid_b__20_0__,0
		              );
		    iVar1 = func_ii_6917(param1_00,uVar2,Method_System_Linq_Enumerable_Single_RefAccountInfo___);
		    uVar2 = *(undefined4 *)(iVar1 + 0x10);
		  }
		  return uVar2;
		}
		*/

			return null;
		}
	}
}
