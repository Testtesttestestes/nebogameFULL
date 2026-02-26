using System;
using Core.Cache;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6C RID: 3436
	[Token(Token = "0x2000D6C")]
	public class DiscountCache : AbstractCache<MedalDicWrapper, IDiscountArgs>
	{
		// Token: 0x06005433 RID: 21555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005433")]
		[Address(RVA = "0xA1EA", Offset = "0xA1EA", VA = "0xA1EA", Slot = "9")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Aprs_Discounts_DiscountCache__Dispose
		               (int param1,undefined4 param2,float param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a59446 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs___ctor__);
		    DAT_ram_00a59446 = '\x01';
		  }
		  Gameplay_Boss_View_AbstractBossWindowView_object__object___Start
		            (param1,param3,Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs___ctor__);
		  *(undefined4 *)(param1 + 0x20) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06005434 RID: 21556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005434")]
		[Address(RVA = "0xA1EB", Offset = "0xA1EB", VA = "0xA1EB")]
		public DiscountCache(AprsModel aprsModel, float ttl)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Discounts_DiscountCache___ctor
		               (int param1,undefined8 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  int param1_00;
		  int iVar1;
		  int param1_01;
		  undefined4 uVar2;
		  undefined4 param1_02;
		  uint uVar3;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a59447 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__AddCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__Complete__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_MedalDicWrapper___);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalDicWrapper__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDiscountArgs__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDiscountArgs__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IDiscountArgs___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Discounts_DiscountCache___c__DisplayClass3_0__Update_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Aprs_Discounts_DiscountCache___c__DisplayClass3_0_TypeInfo);
		    DAT_ram_00a59447 = '\x01';
		  }
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__AddCallback__);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_IDiscountArgs__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,*(undefined4 *)(param4 + 0xc),
		             Method_System_Collections_Generic_List_IDiscountArgs___ctor__);
		  if (0 < *(int *)(param4 + 0xc)) {
		    do {
		      iVar1 = unnamed_function_1417
		                        (Gameplay_Aprs_Discounts_DiscountCache___c__DisplayClass3_0_TypeInfo);
		      *(undefined4 *)(iVar1 + 8) = *(undefined4 *)(param4 + iVar4 * 4 + 0x10);
		      param1_02 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 0x18) + 0x10);
		      uVar2 = unnamed_function_1417(System_Func_MedalDicWrapper__bool__TypeInfo);
		      System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                (uVar2,iVar1,
		                 Method_Gameplay_Aprs_Discounts_DiscountCache___c__DisplayClass3_0__Update_b__0__,0)
		      ;
		      iVar1 = UI_SimpleIconValue__set_Value
		                        (param1_02,uVar2,
		                         Method_System_Linq_Enumerable_SingleOrDefault_MedalDicWrapper___);
		      if (iVar1 != 0) {
		        param1_01 = unnamed_function_1417(Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo);
		        Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_01,2,0);
		        *(int *)(param1_01 + 0x14) = iVar1;
		        uVar2 = Utils_MoneyUtils__CreateZero(1.0 - *(double *)(*(int *)(iVar1 + 0x10) + 0x60),0);
		        *(undefined4 *)(param1_01 + 0xc) = uVar2;
		        iVar1 = Method_System_Collections_Generic_List_IDiscountArgs__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_00 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		          *(int *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = param1_01;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(param4 + 0xc));
		  }
		  uVar2 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                    (param1_00,Method_System_Collections_Generic_List_IDiscountArgs__ToArray__);
		  Core_Cache_AbstractCache_object__object___Cancel
		            (param1,param4,uVar2,
		             Method_Core_Cache_AbstractCache_MedalDicWrapper__IDiscountArgs__Complete__);
		  return;
		}
		*/

		}

		// Token: 0x06005435 RID: 21557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005435")]
		[Address(RVA = "0xA1EC", Offset = "0xA1EC", VA = "0xA1EC", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<IDiscountArgs> completeCallback, params AbstractCache<MedalDicWrapper, IDiscountArgs>.CacheItem[] cacheItems)
		{
		}

		// Token: 0x04002D9C RID: 11676
		[Token(Token = "0x4002D9C")]
		[FieldOffset(Offset = "0x20")]
		private AprsModel _aprs;
	}
}
