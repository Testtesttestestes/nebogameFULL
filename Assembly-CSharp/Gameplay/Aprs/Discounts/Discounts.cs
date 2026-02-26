using System;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6E RID: 3438
	[Token(Token = "0x2000D6E")]
	public class Discounts : IDiscountHandler, IDisposable
	{
		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0000F360 File Offset: 0x0000D560
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001125")]
		public bool IsDisposed
		{
			[Token(Token = "0x6005438")]
			[Address(RVA = "0xA1EF", Offset = "0xA1EF", VA = "0xA1EF")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005439")]
			[Address(RVA = "0xA1F0", Offset = "0xA1F0", VA = "0xA1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543A")]
		[Address(RVA = "0xA1F1", Offset = "0xA1F1", VA = "0xA1F1", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543B")]
		[Address(RVA = "0xA1F2", Offset = "0xA1F2", VA = "0xA1F2")]
		public Discounts(AprsModel model, IDiscountsProvider discountsModel, ICache<MedalDicWrapper, IDiscountArgs> cache)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Discounts_Discounts___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a59449 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicWrapper__ToArray__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Discounts_Discounts___c__DisplayClass9_0__Handle_b__0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Discounts_Discounts___c__DisplayClass9_0_TypeInfo);
		    DAT_ram_00a59449 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Aprs_Discounts_Discounts___c__DisplayClass9_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int *)(iVar2 + 8) = param1;
		  param1_01 = *(int **)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_IDiscountArgs__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (param1_00,iVar2,
		             Method_Gameplay_Aprs_Discounts_Discounts___c__DisplayClass9_0__Handle_b__0__,0);
		  uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (*(undefined4 *)(*(int *)(*(int *)(param1 + 0xc) + 0x18) + 0x10),
		                     Method_System_Collections_Generic_List_MedalDicWrapper__ToArray__);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81005cd6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo
		                                ,1);
		code_r0x81005cd6:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,param1_00,uVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543C")]
		[Address(RVA = "0xA1F3", Offset = "0xA1F3", VA = "0xA1F3", Slot = "4")]
		public void Handle(IDiscountTarget target)
		{
		/* --- GHIDRA: Handle ---
		void Gameplay_Aprs_Discounts_Discounts__Handle(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5944a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Array_Empty_MedalDicWrapper___);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo);
		    DAT_ram_00a5944a = '\x01';
		  }
		  iVar4 = Method_System_Array_Empty_MedalDicWrapper___;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar3 = *(int *)(Method_System_Array_Empty_MedalDicWrapper___ + 0x1c);
		  if (iVar3 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference(Method_System_Array_Empty_MedalDicWrapper___);
		    iVar3 = *(int *)(iVar4 + 0x1c);
		  }
		  iVar3 = *(int *)(iVar3 + 8);
		  if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		    iVar3 = func_ii_1079(iVar3);
		  }
		  if (*(int *)(iVar3 + 0x74) == 0) {
		    func_ii_306000(iVar3);
		  }
		  iVar4 = *(int *)(*(int *)(iVar4 + 0x1c) + 8);
		  if ((*(byte *)(iVar4 + 0xbd) & 1) == 0) {
		    iVar4 = func_ii_1079(iVar4);
		  }
		  uVar1 = 0;
		  uVar5 = **(undefined4 **)(iVar4 + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo ==
		          *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x81005df0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Cache_ICache_MedalDicWrapper__IDiscountArgs__TypeInfo
		                                ,2);
		code_r0x81005df0:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,uVar5,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543D")]
		[Address(RVA = "0xA1F4", Offset = "0xA1F4", VA = "0xA1F4")]
		public void Reset()
		{
		}

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0x8")]
		private IDiscountsProvider _discountsProvider;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0xC")]
		private AprsModel _model;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0x10")]
		private ICache<MedalDicWrapper, IDiscountArgs> _cache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_IsDisposed ---
		void Gameplay_Aprs_Discounts_Discounts__set_IsDisposed(int param1,undefined4 param2)
		
		{
		  *(undefined1 *)(param1 + 0x14) = 1;
		  *(undefined4 *)(param1 + 0x10) = 0;
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

}
