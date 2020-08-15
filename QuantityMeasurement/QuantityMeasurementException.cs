namespace QuantityMeasurement
{
    using System;

    public class QuantityMeasurementException:Exception
    {
        public string Message;

        public enum ExceptionType
        {
            NOT_FOUND,
        }

        ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurementException"/> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        public QuantityMeasurementException(string message, ExceptionType type) : base(string.Format(message))
        {
            this.Message = message;
            this.type = type;
        }
    }
}
