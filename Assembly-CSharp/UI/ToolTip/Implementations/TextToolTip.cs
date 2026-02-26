using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	public class TextToolTip : ToolTip, IToolTipDataProvider
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x5CF6", Offset = "0x5CF6", VA = "0x5CF6", Slot = "9")]
		public override void Dispose()
		{
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000145")]
		public string Text
		{
			[Token(Token = "0x600098F")]
			[Address(RVA = "0x5CF7", Offset = "0x5CF7", VA = "0x5CF7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000990")]
			[Address(RVA = "0x5CF8", Offset = "0x5CF8", VA = "0x5CF8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000146")]
		public IToolTipDataProvider DataProvider
		{
			[Token(Token = "0x6000991")]
			[Address(RVA = "0x5CF9", Offset = "0x5CF9", VA = "0x5CF9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000992")]
			[Address(RVA = "0x5CFA", Offset = "0x5CFA", VA = "0x5CFA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000993")]
		[Address(RVA = "0x5CFB", Offset = "0x5CFB", VA = "0x5CFB", Slot = "10")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x5CFC", Offset = "0x5CFC", VA = "0x5CFC")]
		public void SetMinSize(in Vector2 value)
		{
		/* --- GHIDRA: SetMinSize ---
		void UI_ToolTip_Implementations_TextToolTip__SetMinSize
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  *(undefined8 *)(param1 + 0x20) = *param2;
		  return;
		}
		*/

		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x5CFD", Offset = "0x5CFD", VA = "0x5CFD")]
		public void SetMaxSize(in Vector2 value)
		{
		/* --- GHIDRA: SetMaxSize ---
		int UI_ToolTip_Implementations_TextToolTip__SetMaxSize(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  
		  uVar1 = *(uint *)(param1 + 0x18);
		  if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		    *(uint *)(param2 + 0x14) = uVar1;
		  }
		  else {
		    uVar1 = *(uint *)(param2 + 0x14);
		  }
		  if ((*(uint *)(param1 + 0x1c) & 0x7fffffff) < 0x7f800001) {
		    *(uint *)(param2 + 0x18) = *(uint *)(param1 + 0x1c);
		    *(uint *)(param2 + 0x14) = uVar1;
		  }
		  uVar1 = *(uint *)(param1 + 0x20);
		  if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		    *(uint *)(param2 + 0xc) = uVar1;
		  }
		  else {
		    uVar1 = *(uint *)(param2 + 0xc);
		  }
		  if ((*(uint *)(param1 + 0x24) & 0x7fffffff) < 0x7f800001) {
		    *(uint *)(param2 + 0x10) = *(uint *)(param1 + 0x24);
		    *(uint *)(param2 + 0xc) = uVar1;
		  }
		  return param2;
		}
		*/

		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x5CFE", Offset = "0x5CFE", VA = "0x5CFE")]
		private BaseToolTipData FillSizes(BaseToolTipData data)
		{
		/* --- GHIDRA: FillSizes ---
		void UI_ToolTip_Implementations_TextToolTip__FillSizes(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x20) = 0x7fc000007fc00000;
		  *(undefined8 *)(param1 + 0x18) = 0x7fc000007fc00000;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x5CFF", Offset = "0x5CFF", VA = "0x5CFF")]
		public TextToolTip()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_TextToolTip___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_BaseToolTipData__TypeInfo);
		    DAT_ram_00a5b8d9 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Func_BaseToolTipData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_BaseToolTipData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2 _minSize;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 _maxSize;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_DataProvider ---
		int UI_ToolTip_Implementations_TextToolTip__set_DataProvider(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a5b8d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_IToolTipDataProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_string__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_string__TypeInfo);
		    DAT_ram_00a5b8d8 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(UI_ToolTip_ToolTipData_string__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (iVar2,0,Method_UI_ToolTip_ToolTipData_string___ctor__);
		  param1_00 = *(int **)(param1 + 0x2c);
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(param1 + 0x28);
		    uVar1 = *(uint *)(param1 + 0x18);
		    if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x14) = uVar1;
		    }
		    else {
		      uVar1 = *(uint *)(iVar2 + 0x14);
		    }
		    if ((*(uint *)(param1 + 0x1c) & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x18) = *(uint *)(param1 + 0x1c);
		      *(uint *)(iVar2 + 0x14) = uVar1;
		    }
		    uVar1 = *(uint *)(param1 + 0x20);
		    if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0xc) = uVar1;
		    }
		    else {
		      uVar1 = *(uint *)(iVar2 + 0xc);
		    }
		    if ((*(uint *)(param1 + 0x24) & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x10) = *(uint *)(param1 + 0x24);
		      *(uint *)(iVar2 + 0xc) = uVar1;
		      return iVar2;
		    }
		  }
		  else {
		    uVar1 = 0;
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (UI_ToolTip_IToolTipDataProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)
		           ) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8138fa44;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UI_ToolTip_IToolTipDataProvider_TypeInfo,0);
		code_r0x8138fa44:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar1 = *(uint *)(param1 + 0x18);
		    if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x14) = uVar1;
		    }
		    else {
		      uVar1 = *(uint *)(iVar2 + 0x14);
		    }
		    if ((*(uint *)(param1 + 0x1c) & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x18) = *(uint *)(param1 + 0x1c);
		      *(uint *)(iVar2 + 0x14) = uVar1;
		    }
		    uVar1 = *(uint *)(param1 + 0x20);
		    if ((uVar1 & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0xc) = uVar1;
		    }
		    else {
		      uVar1 = *(uint *)(iVar2 + 0xc);
		    }
		    if ((*(uint *)(param1 + 0x24) & 0x7fffffff) < 0x7f800001) {
		      *(uint *)(iVar2 + 0x10) = *(uint *)(param1 + 0x24);
		      *(uint *)(iVar2 + 0xc) = uVar1;
		    }
		  }
		  return iVar2;
		}
		*/

}
