using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;

namespace Utils
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class CommandsRepository : IDisposable
	{
		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x56D1", Offset = "0x56D1", VA = "0x56D1")]
		public CommandsRepository(float timeout = 3f)
		{
		/* --- GHIDRA: .ctor ---
		int Utils_CommandsRepository___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648df == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Enum__Add__);
		    DAT_ram_00a648df = '\x01';
		  }
		  iVar1 = System_Collections_Generic_HashSet_object___Clear
		                    (*(undefined4 *)(param1 + 8),param2,
		                     Method_System_Collections_Generic_HashSet_Enum__Add__);
		  if (iVar1 != 0) {
		    Utils_CommandsRepository__Remove(param1,param1);
		  }
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x56D2", Offset = "0x56D2", VA = "0x56D2")]
		public bool TryAdd(Enum id)
		{
		/* --- GHIDRA: TryAdd ---
		void Utils_CommandsRepository__TryAdd(int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a648e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Enum__Remove__);
		    DAT_ram_00a648e0 = '\x01';
		  }
		  Unity_Services_Analytics_AnalyticsService__get_Instance
		            (*(undefined4 *)(param1 + 8),param2,
		             Method_System_Collections_Generic_HashSet_Enum__Remove__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x56D3", Offset = "0x56D3", VA = "0x56D3")]
		public void Remove(Enum id)
		{
		/* --- GHIDRA: Remove ---
		void Utils_CommandsRepository__Remove(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  float param1_00;
		  
		  if (DAT_ram_00a648e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_CommandsRepository_Clear__);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a648e1 = '\x01';
		  }
		  if (*(int *)(param1 + 0x10) != 0) {
		    func_ii_7891(*(int *)(param1 + 0x10),0,0);
		  }
		  param1_00 = *(float *)(param1 + 0xc);
		  uVar1 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply(uVar1,param1,Method_Utils_CommandsRepository_Clear__,0);
		  uVar1 = DG_Tweening_DOVirtual__EasedValue(param1_00,uVar1,1,0);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x56D4", Offset = "0x56D4", VA = "0x56D4")]
		private void RefreshTimer()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x56D5", Offset = "0x56D5", VA = "0x56D5")]
		private void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Utils_CommandsRepository__Clear(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a648e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_Enum__Clear__);
		    DAT_ram_00a648e2 = '\x01';
		  }
		  System_Collections_Generic_HashSet___Il2CppFullySharedGenericType___AreEqualityComparersEqual
		            (*(undefined4 *)(param1 + 8),Method_System_Collections_Generic_HashSet_Enum__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x56D6", Offset = "0x56D6", VA = "0x56D6", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		undefined4 Utils_CommandsRepository__Dispose(undefined4 param1)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a648e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Application_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_CoroutineSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_CoroutineSource___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_GameObject_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5806);
		    DAT_ram_00a648e3 = '\x01';
		  }
		  if (*(int *)(UnityEngine_Application_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Application_TypeInfo);
		  }
		  iVar1 = func_ii_3441(0);
		  if ((iVar1 != 0) && (**(int **)(Utils_CoroutineSource_TypeInfo + 0x5c) == 0)) {
		    uVar2 = unnamed_function_1417(UnityEngine_GameObject_TypeInfo);
		    func_ii_13018(uVar2,StringLiteral_5806,0);
		    uVar2 = UnityEngine_GameObject__GetComponent_object_
		                      (uVar2,Method_UnityEngine_GameObject_AddComponent_CoroutineSource___);
		    **(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c) = uVar2;
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (**(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c),0);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Object__FindObjectsByType(uVar2,0);
		  }
		  return **(undefined4 **)(Utils_CoroutineSource_TypeInfo + 0x5c);
		}
		*/

		}

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x8")]
		private readonly HashSet<Enum> _ids;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _timeout;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x10")]
		private Tween _tween;
	}
}
