using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Domain.ValueObjects
{
    /// <summary>
    /// エリアID
    /// </summary>
    /// 完全コンストラクタパターン(※)で作成する。
    /// ※コンストラクタで値設定後は、値を変更できないクラス。
    public sealed class AreaId : ValueObject<AreaId>
    {

        public AreaId(int value)
        {
            Value = value;
        }

        public int Value { get; }


        public string DisplayValue => Value.ToString().PadLeft(4, '0');
        protected override bool EqualsCore(AreaId other)
        {
            return this.Value == other.Value;
        }
    }
}
