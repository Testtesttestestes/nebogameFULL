using System;
using Il2CppDummyDll;

namespace UI.Windows
{
	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	public class NotFoundWindowObject : NotFoundWindowKey
	{
		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700021B")]
		public override string Message
		{
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x616F", Offset = "0x616F", VA = "0x616F", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x6170", Offset = "0x6170", VA = "0x6170")]
		public NotFoundWindowObject(string windowId)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_NotFoundWindowObject___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a639f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_8134);
		    DAT_ram_00a639f3 = '\x01';
		  }
		  param2_00 = *(undefined4 *)(param1 + 0x48);
		  uVar1 = GAFInternal_Assets_GAFAnimationAssetInternal__collectExternalData
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_8134,param2_00,uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		private const string FORMAT = "Not found window GameObject. [{0}]";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Message ---
		void UI_Windows_NotFoundWindowObject__get_Message(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a639f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Exception_TypeInfo);
		    DAT_ram_00a639f1 = '\x01';
		  }
		  if (*(int *)(System_Exception_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Exception_TypeInfo);
		  }
		  System_Exception__Init(param1,0);
		  *(undefined4 *)(param1 + 0x48) = param2;
		  return;
		}
		*/

}
